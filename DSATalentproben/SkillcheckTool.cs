using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Xml.Linq;
using static DSASkillchecks.Hero;
using static DSASkillchecks.Filehandler;

/*
 * To do:
 * save/read value for initiative
 * unit-test for skillcheck method
 */

namespace DSASkillchecks
{
    public partial class SkillcheckTool : Form
    {
        Random r = new Random();
        Talent selectedTalent;
        bool edited = false;
        string[] categories = { "waffen", "körperlich", "gesellschaft", "natur", "wissen", "sprachen", "handwerk" }; 
        int currentCategory;
        string versionNumber = "1.2";
        Hero hero = new Hero("Heldenname");
        NumericUpDown[] entryAttributes;
        Filehandler filehandler = new Filehandler();
        Paths paths = new Paths();

        public SkillcheckTool()
        {
            InitializeComponent();
        }

        private void SkillcheckTool_Load(object sender, EventArgs e)
        {
            versionInfo.Text = $"*** v{versionNumber} 2021 von Ofenkatze (mail@jennystevens.de) ***";
            entryAttributes = new NumericUpDown[] { MU, KL, IN, CH, FF, GE, KO, KK };
            InitializeInputFields(hero);
            currentCategory = 0;
            listBoxTalents.SelectedIndex = 0;
        }

        private void InitializeInputFields(Hero hero)
        {
            tbHeroName.Text = hero.name;
            LoadAttributesToTB();
            LoadTalentsToListbox();
        }

        private void LoadAttributesToTB()
        {
            foreach (var attribute in hero.attr)
            {
                NumericUpDown correspondingNUM = this.Controls.Find(attribute.Key, true).FirstOrDefault() as NumericUpDown;
                correspondingNUM.Value = attribute.Value;
            }

        }

        private void LoadTalentsToListbox()
        {
            listBoxTalents.Items.Clear();
            for (int i = 0; i < categories.Length; i++)
            {
                if (i != 0) listBoxTalents.Items.Add("");
                listBoxTalents.Items.Add(categories[i].ToUpper());
                PrintTalentsByCategory(i);
            }
        }

        private void PrintTalentsByCategory(int category)
        {
            foreach (Talent t in hero.talents)
            {
                if (t.category == category)
                {
                    listBoxTalents.Items.Add(t);
                }
                if (t.category > category)
                    break;
            }
        }

        private void listBoxTalents_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtons();
            Type selectionType = (sender as ListBox).SelectedItem.GetType();
            String selectionContent = (sender as ListBox).SelectedItem.ToString();

            //if selection is an empty line, return
            if (string.IsNullOrEmpty(selectionContent))
            {
                DisableButtons();
                return;
            }

            // if selection is a talent, load talent
            if (selectionType.Equals(typeof(Talent)))
            {
                Talent t = ((sender as ListBox).SelectedItem as Talent);
                selectedTalent = t;
                LoadTalentInfo(t);
                labelCategory.Text = categories[t.category].ToUpper();
                currentCategory = t.category;
                return;
            }

            // if selection is a category headline, select current category
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
        
        private void LoadTalentInfo(Talent t)
        {
            selectedTalent = t;
            currentCategory = t.category;
            tbTalentName.Text = t.name;
            tbTalentValue.Text = t.talentValue.ToString();
            cbAttr01.SelectedItem = t.attr01;
            cbAttr02.SelectedItem = t.attr02;
            cbAttr03.SelectedItem = t.attr03;
            modifier.Text = "" + 0;
            modifier.Focus();
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

            hero.talents.Sort();
            LoadTalentsToListbox();
            listBoxTalents.SelectedItem = selectedTalent;
            UpdateAttributes();
            edited = true;
        }

        private void btnNewTalent_Click(object sender, EventArgs e)
        {
            TalentNew(currentCategory);
            LoadTalentInfo(selectedTalent);
            edited = true;
        }

        private void btnDeleteTalent_Click(object sender, EventArgs e)
        {
            TalentDelete(selectedTalent);
            edited = true;
        }

        private void TalentNew(int category)
        {
            List<Talent> neueTalente = hero.talents.FindAll(t => t.name.Contains("Neues Talent"));
            int i = neueTalente.Count+1;

            selectedTalent = new Talent() { name = "Neues Talent"+i, attr01 = "MU", attr02 = "MU", attr03 = "MU", talentValue = 0, category = category };

            hero.talents.Add(selectedTalent);
            hero.talents.Sort();
            LoadTalentsToListbox();
            listBoxTalents.SelectedItem = selectedTalent;
        }

        private void TalentDelete(Talent t)
        {
            int i = hero.talents.FindIndex(x => x == t);
            int posListBox = listBoxTalents.SelectedIndex;
            hero.talents.RemoveAt(i);
            LoadTalentsToListbox();
            listBoxTalents.SelectedIndex = posListBox-1;
            edited = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (filehandler.Filename == string.Empty)
            {
                btnSaveAs.PerformClick();
            }
            else
            {
                SaveFile(hero, filehandler, paths);
                MessageBox.Show("Held gespeichert!");
            }
            this.Text = $"DSA Talentprobenrechner v{versionNumber} - {filehandler.Filename}";
            edited = false;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "XML-Dateien|*.xml";
            saveDialog.FileName = string.Empty;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                filehandler.Filename = saveDialog.FileName;
                paths = filehandler.SetFilePaths(filehandler.Filename);
                SaveFile(hero, filehandler, paths);
            }
        }

        private void SaveFile(Hero hero, Filehandler filehandler, Paths paths)
        {
            UpdateAttributes();
            filehandler.SaveAttributes(paths.fileAttributes, hero);
            filehandler.SaveTalents(paths.fileTalents, hero);
            filehandler.SaveHero(filehandler.Filename, paths.fileAttributes, paths.fileTalents, hero);
        }

        private void UpdateAttributes()
        {
            foreach (NumericUpDown num in entryAttributes)
            {
                hero.attr[num.Name] = Convert.ToInt32(num.Value);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (edited ||  CheckAttributesChanged())
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
                    filehandler.Filename = openDialog.FileName;
                    paths = filehandler.SetFilePaths(filehandler.Filename);

                    filehandler.ReadAttributes(paths.fileAttributes, hero);
                    LoadAttributesToTB();

                    filehandler.ReadTalents(paths.fileTalents, hero);
                    currentCategory = 0;
                    LoadTalentsToListbox();
                    listBoxTalents.SelectedIndex = 0;
                    
                    filehandler.ReadHero(filehandler.Filename, hero);
                    tbHeroName.Text = hero.name;
                    
                    edited = false;
                    this.Text = $"DSA Talentprobenrechner v{versionNumber} - {filehandler.Filename}";
                }
                catch
                {
                    MessageBox.Show("Keine gültige Heldendatei");
                    return;
                }
            }
        }

        private bool CheckAttributesChanged()
        {
            bool changed = false;
            foreach (NumericUpDown num in entryAttributes)
            {
                foreach (var attribute in hero.attr)
                    if (attribute.Value != num.Value)
                    { changed = true; }
            }
            return changed;
        }

        private void PerformSkillcheck_Click(object sender, EventArgs e)
        {
            if (selectedTalent != null)
            {
                Label[] outputRolls = { rollResult01, rollResult02, rollResult03 };
                Label[] outputTalentValue = { tvRemainder01, tvRemainder02, tvRemainder03 };
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
                
                skillcheckResult result = hero.RollHouserule(r, selectedTalent, mod);
                rollResult01.Text = result.rolls[0].ToString();
                for (int i = 0; i < 3; i++)
                {
                    outputRolls[i].Text = "" + result.rolls[i] + " gegen " + result.attributes[i];
                    outputTalentValue[i].Text = result.talentValueRemainder[i].ToString();
                }
                OutputResult(result.talentValueRemainder[2], result.fumbleCounter, mod);

                //reset attributes to original values
                LoadTalentInfo(selectedTalent);
            }
        }

        private void OutputResult(int remainder, int fumbleCounter, int mod)
        {
            int difficulty = 0;

            // if skillcheck is actually made easier, adjust modifier value
            if (mod < 0)
            { difficulty = selectedTalent.talentValue + mod; }

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
                        listBoxHistory.Items.Add(selectedTalent.name.PadRight(30, ' ') + "\tÜbrige Punkte: " + Convert.ToString(remainder));
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
            hero.name = tbHeroName.Text;
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
