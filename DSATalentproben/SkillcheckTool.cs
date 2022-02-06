using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static DSASkillchecks.Hero;
using static DSASkillchecks.Die;

/*
 * To do:
 * add weapons stats
 * save notes
 * add action counter
 * catch file edited when combat stats are changed
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
        string versionNumber = "1.5";
        Hero hero = new Hero("Heldenname");
        NumericUpDown[] entryAttributes;
        NumericUpDown[] entryCombat;
        Filehandler fh = new Filehandler();

        public SkillcheckTool()
        {
            InitializeComponent();
        }

        private void SkillcheckTool_Load(object sender, EventArgs e)
        {
            versionInfo.Text = $"*** v{versionNumber} 2021 von Ofenkatze (mail@jennystevens.de) ***";
            entryAttributes = new NumericUpDown[] { MU, KL, IN, CH, FF, GE, KO, KK };
            entryCombat = new NumericUpDown[] { initiative, ausweichen, behinderung, LE, AE };
            InitializeInputFields(hero);
            currentCategory = 0;
            listBoxTalents.SelectedIndex = 0;
        }

        private void InitializeInputFields(Hero hero)
        {
            tbHeroName.Text = hero.name;
            ruleVersionSelect.SelectedIndex = hero.ruleVersion;
            LoadAttributesToNum();
            LoadCombatToNum();
            LoadTalentsToListbox();
        }

        private void LoadAttributesToNum()
        {
            foreach (KeyValuePair<string, int> attribute in hero.attr)
            {
                NumericUpDown correspondingNUM = this.Controls.Find(attribute.Key, true).FirstOrDefault() as NumericUpDown;
                correspondingNUM.Value = attribute.Value;
            }
        }

        private void LoadCombatToNum()
        {
            foreach (KeyValuePair<string, int> stat in hero.combat)
            {
                NumericUpDown correspondingNUM = this.Controls.Find(stat.Key, true).FirstOrDefault() as NumericUpDown;
                correspondingNUM.Value = stat.Value;
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
                selectedTalent = ((sender as ListBox).SelectedItem as Talent);
                LoadTalentInfo(selectedTalent);
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
            foreach (NumericUpDown num in entryAttributes)
            { num.BackColor = Color.White; }
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
            labelCategory.Text = categories[t.category].ToUpper();
            modifier.Text = "" + 0;
            modifier.Focus();

            //highlight corresponding attributes in GUI
            Dictionary<string, int> selectedAttributes = new Dictionary<string, int>();
            selectedAttributes[t.attr01] = hero.attr[t.attr01];
            selectedAttributes[t.attr02] = hero.attr[t.attr02];
            selectedAttributes[t.attr03] = hero.attr[t.attr03];
            selectedAttributes = selectedAttributes.OrderByDescending(u => u.Value).ToDictionary(z => z.Key, y => y.Value);
            Color[] colors = { Color.LightGreen, Color.Gold, Color.Orange };
            int i = 0;
            foreach (KeyValuePair<string, int> kvp in selectedAttributes)
            {
                NumericUpDown correspondingNUM = this.Controls.Find(kvp.Key, true).FirstOrDefault() as NumericUpDown;
                correspondingNUM.BackColor = colors[i];
                i++;
            }
            selectedAttributes.Clear();
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
            if (fh.Filename == string.Empty)
            {
                btnSaveAs.PerformClick();
            }
            else
            {
                UpdateAttributes();
                fh.SaveHeroFile(fh.Filename, hero);
                MessageBox.Show("Held gespeichert!");
            }
            this.Text = $"DSA Talentprobenrechner v{versionNumber} - {fh.Filename}";
            edited = false;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "XML-Dateien|*.xml";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                fh.Filename = saveDialog.FileName;
                UpdateAttributes();
                fh.SaveHeroFile(fh.Filename, hero);
            }
        }

        private void UpdateAttributes()
        {
            foreach (NumericUpDown num in entryAttributes)
            {
                hero.attr[num.Name] = Convert.ToInt32(num.Value);
            }
            foreach (NumericUpDown num in entryCombat)
            {
                hero.combat[num.Name] = Convert.ToInt32(num.Value);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (edited | AttributesChanged())
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

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fh.Filename = openDialog.FileName;
                    hero = fh.LoadHeroFile(fh.Filename, hero);
                    LoadAttributesToNum();
                    LoadCombatToNum();
                    LoadTalentsToListbox();
                    currentCategory = 0;
                    listBoxTalents.SelectedIndex = 0;
                    tbHeroName.Text = hero.name;
                    ruleVersionSelect.SelectedIndex = hero.ruleVersion;

                    edited = false;
                    this.Text = $"DSA Talentprobenrechner v{versionNumber} - {fh.Filename}";
                }
                catch
                {
                    MessageBox.Show("Keine gültige Heldendatei");
                    return;
                }
            }
        }

        private bool AttributesChanged()
        {
            List<int> attributes = hero.attr.Values.ToList();
            List<int> attributesUI = new List<int>();

            foreach (NumericUpDown num in entryAttributes)
            { attributesUI.Add(Convert.ToInt32(num.Value)); }

            bool isEqual = Enumerable.SequenceEqual(attributes, attributesUI);
            if (isEqual) return false;
            else return true;
        }

        private void PerformSkillcheck_Click(object sender, EventArgs e)
        {
            if (selectedTalent != null)
            {
                Label[] outputRolls = { rollResult01, rollResult02, rollResult03 };
                Label[] outputTalentValue = { tvRemainder01, tvRemainder02, tvRemainder03 };
                skillcheckResult result;
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

                if (ruleVersionSelect.SelectedIndex == 1)
                { result = hero.RollHouserule(r, selectedTalent, mod); }
                else
                { result = hero.RollVanilla(r, selectedTalent, mod); }
             
                for (int i = 0; i < 3; i++)
                {
                    outputRolls[i].Text = $"{result.rolls[i]} gegen {result.attributes[i]}";
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

        private void btn_d6_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(d6Count.Value);
            int mod = Convert.ToInt32(d6Mod.Value);
            Die die = new Die(6);
            rollResult result = die.Roll(r, amount, mod);
            PrintRollResults(die, result);
        }

        private void btn_d20_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(d20Count.Value);
            int mod = Convert.ToInt32(d20Mod.Value);
            Die die = new Die(20);
            rollResult result = die.Roll(r, amount, mod);
            PrintRollResults(die, result);
        }

        private void rollIni_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(iniCount.Value);
            int mod = Convert.ToInt32(initiative.Value);
            Die die = new Die(6);
            rollResult result = die.Roll(r, amount, mod);
            PrintRollResults(die, result);
            iniTmp.Text = result.accumulated.ToString();
        }

        private void PrintRollResults(Die die, rollResult result)
        {
            // output number and kind of dice rolled. Example string: "3 W6", "1W 20"
            string rolled = $"{result.rolls.Count} W{die.type} +{result.mod}";
            outputDieType.Text = rolled;

            // output roll values. Example string: "2, 4", "20, 12, 9"
            string results = string.Join<int>(", ", result.rolls);
            outputRolls.Text = results;

            // output accumulated roll values
            string acc = result.accumulated.ToString();
            outputAccumulated.Text = result.accumulated.ToString();

            // output to history
            output.Items.Add($"{rolled,-10} = {acc,-5} {results}");
            output.Items.Add("");
            output.SelectedIndex = output.Items.Count - 1;
            output.SetSelected(output.Items.Count - 1, false);
        }

        private void ruleVersionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            hero.ruleVersion = ruleVersionSelect.SelectedIndex;
        }
    }
}
