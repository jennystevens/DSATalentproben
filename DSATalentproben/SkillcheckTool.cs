using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;

/*
 * To do:
 * save/read value for initiative
 * separate logic from UI
 * Hero-object instead of reading/writing directly from XML
 * unit-tests
 */

namespace DSASkillchecks
{
    public partial class SkillcheckTool : Form
    {
        Random r = new Random();
        int rollAttr01, rollAttr02, rollAttr03 = 0;
        int talentValue = 0;
        List<Talent> talents = new List<Talent>();
        Talent selectedTalent;
        int[] attributes = new int[8];
        int fumbleCounter = 0;
        string filename = string.Empty;
        string heroName = string.Empty;
        bool edited = false;
        string[] categories = { "waffen", "körperlich", "gesellschaft", "natur", "wissen", "sprachen", "handwerk" };
        int currentCategory;
        string versionNumber = "5.0";

        struct Filepaths
        {
            public string fileAttributes { get; set; }
            public string fileTalents { get; set; }
        }
        Filepaths paths = new Filepaths();

        public SkillcheckTool()
        {
            InitializeComponent();
        }

        private void SkillcheckTool_Load(object sender, EventArgs e)
        {
            versionInfo.Text = $"*** v{versionNumber} 2021 von Ofenkatze (mail@jennystevens.de) ***";
            LoadTalentsToListbox();
            currentCategory = 0;
            listBoxTalents.SelectedIndex = 0;
        }

        private void listBoxTalents_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtons();
            Type selectionType = (sender as ListBox).SelectedItem.GetType();
            String selectionContent = (sender as ListBox).SelectedItem.ToString();

            if (string.IsNullOrEmpty(selectionContent))
            {
                DisableButtons();
                return;
            }

            if (selectionType.Equals(typeof(Talent)))
            {
                Talent t = ((sender as ListBox).SelectedItem as Talent);
                SelectTalent(t);
                labelCategory.Text = categories[t.category].ToUpper();
                currentCategory = t.category;
                return;
            }

            if (selectionType.Equals(typeof(String)))
            {
                string ueberschrift = ((sender as ListBox).SelectedItem as String).ToLower();
                for (int i = 0; i < categories.Length; i++)
                {
                    if (categories[i] == ueberschrift)
                    {
                        labelCategory.Text = categories[i].ToUpper();
                        currentCategory = i;
                        DisableButtons();
                        btnNewTalent.Enabled = true;
                        listBoxTalents.SelectedItem = categories[i];
                    }
                }
            }
        }

        private void DisableButtons()
        {
            tbTalentName.Text = "";
            tbTalentValue.Text = "";
            btnNewTalent.Enabled = false;
            btnDeleteTalent.Enabled = false;
            btnApply.Enabled = false;
            performSkillcheck.Enabled = false;
        }

        private void EnableButtons()
        {
            btnNewTalent.Enabled = true;
            btnDeleteTalent.Enabled = true;
            btnApply.Enabled = true;
            performSkillcheck.Enabled = true;
        }

        private void FocusTextbox(TextBox tb)
        {
            tb.Focus();
            tb.SelectionStart = 0;
            tb.SelectionLength = tb.Text.Length;
        }

        private void SelectTalent(Talent t)
        {
            selectedTalent = t;
            currentCategory = t.category;
            LoadTalentInfo(t);
            modifier.Text = "" + 0;
            modifier.Focus();
        }

        private void LoadTalentsToListbox()
        {
            listBoxTalents.Items.Clear();
            for (int i = 0; i < 7; i++)
            {
                if(i!=0) listBoxTalents.Items.Add("");
                listBoxTalents.Items.Add(categories[i].ToUpper());
                PrintTalentsByCategory(i);
            }
        }
        
        private void PrintTalentsByCategory(int category)
        {
            foreach (Talent t in talents)
            {
                if (t.category == category)
                {
                    listBoxTalents.Items.Add(t);
                }
                if (t.category > category)
                    break;
            }
        }

        private void LoadTalentInfo(Talent t)
        {
            tbTalentName.Text = t.name;
            tbTalentValue.Text = "" + t.talentValue;
            cbAttr01.SelectedItem = t.attr01;
            cbAttr02.SelectedItem = t.attr02;
            cbAttr03.SelectedItem = t.attr03;

            TextBox attr01 = this.Controls.Find(t.attr01, true).FirstOrDefault() as TextBox;
            rollAttr01 = Convert.ToInt32(attr01.Text);
            TextBox attr02 = this.Controls.Find(t.attr02, true).FirstOrDefault() as TextBox;
            rollAttr02 = Convert.ToInt32(attr02.Text);
            TextBox attr03 = this.Controls.Find(t.attr03, true).FirstOrDefault() as TextBox;
            rollAttr03 = Convert.ToInt32(attr03.Text);
            talentValue = t.talentValue;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (selectedTalent == null)
            {
                TalentNew(currentCategory);
            }
            selectedTalent.name = tbTalentName.Text;
            try
            {
                selectedTalent.talentValue = Convert.ToInt32(tbTalentValue.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ungültiger Wert: Talentwert");
                FocusTextbox(tbTalentValue);
                return;
                throw;
            }
            selectedTalent.attr01 = cbAttr01.SelectedItem as string;
            selectedTalent.attr02 = cbAttr02.SelectedItem as string;
            selectedTalent.attr03 = cbAttr03.SelectedItem as string;
            selectedTalent.category = currentCategory;

            talents.Sort();
            LoadTalentsToListbox();
            listBoxTalents.SelectedItem = selectedTalent;
            edited = true;
        }

        private void btnNewTalent_Click(object sender, EventArgs e)
        {
            TalentNew(currentCategory);
            LoadTalentInfo(selectedTalent);
        }

        private void btnDeleteTalent_Click(object sender, EventArgs e)
        {
            TalentDelete(selectedTalent);
        }

        private void TalentNew(int k)
        {
            List<Talent> neueTalente = talents.FindAll(t => t.name.Contains("Neues Talent"));
            int i = neueTalente.Count+1;

            selectedTalent = new Talent() { name = "Neues Talent"+i, attr01 = "MU", attr02 = "MU", attr03 = "MU", talentValue = 0, category = k };

            talents.Add(selectedTalent);
            talents.Sort();
            LoadTalentsToListbox();
            listBoxTalents.SelectedItem = selectedTalent;
        }

        private void TalentDelete(Talent t)
        {
            int i = talents.FindIndex(x => x == t);
            int posListBox = listBoxTalents.SelectedIndex;
            talents.RemoveAt(i);
            LoadTalentsToListbox();
            listBoxTalents.SelectedIndex = posListBox-1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (filename == string.Empty)
            {
                btnSaveAs.PerformClick();
            }
            else
            {
                SaveAttributes(paths.fileAttributes);
                SaveTalents(paths.fileTalents);
                SaveHero(filename, paths.fileAttributes, paths.fileTalents);
                MessageBox.Show("Held gespeichert!");
            }
            this.Text = $"DSA Talentprobenrechner v{versionNumber} - {filename}";
            edited = false;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "XML-Dateien|*.xml";
            saveDialog.FileName = string.Empty;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                SetFilePaths(saveDialog.FileName);
                SaveAttributes(paths.fileAttributes);
                SaveTalents(paths.fileTalents);
                SaveHero(saveDialog.FileName, paths.fileAttributes, paths.fileTalents);
                filename = saveDialog.FileName;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (edited)
            {
                DialogResult result = MessageBox.Show("Wollen Sie die Änderungen speichern?", "Ungespeicherte Änderungen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                if (result == DialogResult.No)
                {
                    edited = false;
                }
                if (result == DialogResult.Yes)
                {
                    btnSave.PerformClick();
                }
            }

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "XML-Dateien|*.xml";
            openDialog.FileName = string.Empty;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SetFilePaths(openDialog.FileName);
                    ReadAttributes(paths.fileAttributes);
                    LoadAttributesToTB();
                    ReadTalents(paths.fileTalents);
                    ReadHero(openDialog.FileName);
                    filename = openDialog.FileName;
                    this.Text = $"DSA Talentprobenrechner v{versionNumber} - {filename}";
                }
                catch
                {
                    MessageBox.Show("Keine gültige Heldendatei");
                    return;
                }
            }
        }

        private void SaveTalents(string path)
        {
            XmlSerializer serial = new XmlSerializer(typeof(List<Talent>));
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, talents);
            }
        }
        
        private void SaveHero(string path, string attributes, string talents)
        {
            using (StreamWriter fileHero = new StreamWriter(path))
            {
                fileHero.WriteLine(heroName);
                fileHero.WriteLine(attributes);
                fileHero.WriteLine(talents);
            }
        }

        private void SaveAttributes(string path)
        {
            TextBox[] tbAttributes = { MU, KL, IN, CH, FF, GE, KO, KK };
            Array.Clear(attributes, 0, attributes.Length);
            for (int i = 0; i < 8; i++)
            {
                attributes[i] = Convert.ToInt32(tbAttributes[i].Text);
            }

            XmlSerializer serial = new XmlSerializer(typeof(int[]));
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, attributes);
            }
        }

        private void SetFilePaths(string filepath)
        {
            string path = Path.GetDirectoryName(filepath);
            string dateiname = Path.GetFileNameWithoutExtension(filepath);
            paths.fileAttributes = path + "\\" + dateiname + "_attribute.xml";
            paths.fileTalents = path + "\\" + dateiname + "_talente.xml";
        }

        private void ReadTalents(string path) 
        {
            XmlSerializer serial = new XmlSerializer(typeof(List<Talent>));
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                talents = serial.Deserialize(fs) as List<Talent>;
            }
            currentCategory = 0;
            LoadTalentsToListbox();
            listBoxTalents.SelectedIndex = 0;
        }

        private void ReadAttributes(string path)
        {
            XmlSerializer serial = new XmlSerializer(typeof(int[]));
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                attributes = (serial.Deserialize(fs)) as int[];
            }
        }

        private void ReadHero(string path)
        {
            using (StreamReader fileHero = new StreamReader(path))
            {
                heroName = fileHero.ReadLine();
            }
            tbHeroName.Text = heroName;
            edited = false;
        }

        private void LoadAttributesToTB()
        {
            TextBox[] tbAttributes = { MU, KL, IN, CH, FF, GE, KO, KK };
            for (int i=0; i<8; i++)
            {
                tbAttributes[i].Text = "" + attributes[i];
            }
        }

        private void PerformSkillcheck_Click(object sender, EventArgs e)
        {
            if (selectedTalent!= null)
            {
                fumbleCounter = 0;
                int mod;
                try
                {
                    mod = Convert.ToInt32(modifier.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ungültiger Wert: Modifikator");
                    FocusTextbox(modifier);
                    return;
                    throw;
                }
                int tvRemainder = talentValue;
                int[] attributes = { rollAttr01, rollAttr02, rollAttr03 };

                //perform skillcheck
                tvRemainder = RollHouserule(attributes, tvRemainder, mod);
                OutputResult(tvRemainder);

                //reset attributes to original values
                LoadTalentInfo(selectedTalent); 
            }
        }

        private int RollHouserule(int[] attributes, int talentValue, int mod)
        {
            Label[] outputRolls = { rollResult01, rollResult02, ausgabeWurf03 };
            Label[] outputTalentValue = { tvRemainder01, tvRemainder02, tvRemainder03 };
            int[] rolls = new int[3];
            int[] modifiers = { 0, 0, 0 };

            // roll three times and save to rolls array
            for (int i = 0; i < 3; i++)
            {
                rolls[i] = r.Next(1, 21);
                if (rolls[i] == 20) fumbleCounter++; 
            }

            // split modifier into three integers and save to array modifiers
            if(mod != 0)
            {
                double modSingleD = (double)mod / 3;
                int modSingle = (int)Math.Round((double)modSingleD);
                for (int i = 0; i < 3; i++)
                {
                    modifiers[i] = modSingle;
                }
                if (modSingle * 3 < mod) modifiers[0] = modifiers[0] + 1;
                if (modSingle * 3 > mod) modifiers[2] = modifiers[2] - 1;
            }
            
            // arrange both arrays (rolls and attributes) in descending order
            Array.Sort(rolls);
            Array.Reverse(rolls);
            Array.Sort(attributes);
            Array.Reverse(attributes);

            //subtract modifiers from attributes
            for (int i = 0; i < 3; i++)
            {
                attributes[i] = attributes[i] - modifiers[i];
            }

            // subtract roll from each attribute
            for (int i = 0; i < 3; i++)
            {
                int delta = attributes[i] - rolls[i];
                // if negative: subtract difference from talent value
                if (delta < 0) talentValue += delta; 

                outputRolls[i].Text = "" + rolls[i] + " gegen " + attributes[i];
                outputTalentValue[i].Text = "" + talentValue;
            }

            return talentValue;
        }

        private void btn_d6_Click(object sender, EventArgs e)
        {
            int kindOfDie = 6;
            RollDie(kindOfDie);
        }

        private void btn_d20_Click(object sender, EventArgs e)
        {
            int kindOfDie = 20;
            RollDie(kindOfDie);
        }

        private void RollDie(int kindOfDie)
        {
            int amount = Convert.ToInt32(diceCount.Value);
            int mod = Convert.ToInt32(diceMod.Value);
            int[] rolls = new int[amount];
            string results = String.Empty;
            int accumulated = 0;

            for (int i = 0; i < amount; i++)
            {
                rolls[i] = r.Next(1, kindOfDie + 1);
                accumulated += rolls[i];
                if (i == 0)
                { results = "" + rolls[i]; }
                else
                { results += (", " + rolls[i]); }
            }

            accumulated += mod;
            string rolled = "" + amount + "W" + kindOfDie;
            string history = "" + rolled + "   " + results + "   (" + accumulated +")";
            output.Items.Add(history);
            outputAccumulated.Text = "" + accumulated;
            outputDiceKind.Text = "" + rolled;
            outputRolls.Text = results;
        }

        private void tbHeroName_TextChanged(object sender, EventArgs e)
        {
            heroName = tbHeroName.Text;
            edited = true;
        }

        private void SkillcheckTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edited)
            {
                DialogResult result = MessageBox.Show("Wollen Sie die Änderungen speichern?", "Ungespeicherte Änderungen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                if (result == DialogResult.No)
                {
                    edited = false;
                    this.Close();
                }
                if (result == DialogResult.Yes)
                {
                    btnSave.PerformClick();
                }
            }
        }

        private void OutputResult(int remainder)
        {
            int mod = Convert.ToInt32(modifier.Text);
            int difficulty = 0;

            // if skillcheck is actually made easier, adjust modifier value
            if (mod < 0)
            { difficulty = talentValue + mod; }
            
            if (fumbleCounter < 2)
            {
                if (remainder >= difficulty)
                {
                    result.BackColor = Color.LightGreen;
                    if (remainder <= 0) 
                    { 
                        result.Text = "Geschafft!";
                        listBoxHistory.Items.Add(selectedTalent.name.PadRight(30, ' ') + "\tÜbrige Punkte: 0");
                    }
                    else 
                    { 
                        result.Text = "Geschafft! " + remainder + " übrig";
                        listBoxHistory.Items.Add(selectedTalent.name.PadRight(30,' ') + "\tÜbrige Punkte: " + Convert.ToString(remainder));
                    }
                }
                else
                {
                    result.Text = "Verkackt!";
                    result.BackColor = Color.Salmon;
                    listBoxHistory.Items.Add(selectedTalent.name.PadRight(30, ' ') + "\tverkackt");
                }
            }
            else
            {
                result.Text = "PATZER!";
                result.BackColor = Color.Red;
                listBoxHistory.Items.Add(selectedTalent.name.PadRight(30, ' ') + " verpatzt");
            }
            listBoxHistory.SelectedIndex = listBoxHistory.Items.Count - 1;
            listBoxHistory.SetSelected(listBoxHistory.Items.Count - 1, false);
        }

        private void tbTalentname_Enter(object sender, EventArgs e)
        {
            tbTalentName.SelectionStart = 0;
            tbTalentName.SelectionLength = tbTalentName.Text.Length;
        }

        private void tbTalentname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnApply.PerformClick();
            }
        }

        private void tbTalentvalue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnApply.PerformClick();
            }
        }
    }
}
