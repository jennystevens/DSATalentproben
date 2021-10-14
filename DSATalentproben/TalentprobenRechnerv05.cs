using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Win32;
using System.Diagnostics;

/*
 * To do:
 * Initiative-Wert abspeichern / auslesen
 */

namespace DSATalentproben
{
    public partial class TalentprobenRechner : Form
    {
        Random r = new Random();
        int wuerfelAttr01, wuerfelAttr02, wuerfelAttr03 = 0;
        int talentwert = 0;
        List<Talent> talente = new List<Talent>();
        Talent ausgewaehlt;
        int[] attribute = new int[8];
        int patzerzaehler = 0;
        string dateiname = string.Empty;
        string heldenname = string.Empty;
        bool bearbeitet = false;
        string[] kategorien = { "waffen", "körperlich", "gesellschaft", "natur", "wissen", "sprachen", "handwerk" };
        int aktuelleKategorie;
        string versionsnummer = "5.0";

        //struct Kategorie
        //{
        //    public int kategorie { get; set; }
        //    public string kName { get; set; }
        //}
        //Kategorie[] kats = { };

        struct Dateipfade
        {
            public string dateiAttribute { get; set; }
            public string dateiTalente { get; set; }
        }
        Dateipfade pfade = new Dateipfade();

        public TalentprobenRechner()
        {
            InitializeComponent();
        }

        private void TalentprobenRechner_Load(object sender, EventArgs e)
        {
            versionInfo.Text = $"*** v{versionsnummer} 2021 von Ofenkatze (mail@jennystevens.de) ***";
            LadeTalenteInListbox();
            aktuelleKategorie = 0;
            listBoxTalente.SelectedIndex = 0;
        }

        private void listBoxTalente_SelectedIndexChanged(object sender, EventArgs e)
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
                waehleTalent(t);
                labelKategorie.Text = kategorien[t.kategorie].ToUpper();
                aktuelleKategorie = t.kategorie;
                return;
            }

            if (selectionType.Equals(typeof(String)))
            {
                string ueberschrift = ((sender as ListBox).SelectedItem as String).ToLower();
                for (int i = 0; i < kategorien.Length; i++)
                {
                    if (kategorien[i] == ueberschrift)
                    {
                        labelKategorie.Text = kategorien[i].ToUpper();
                        aktuelleKategorie = i;
                        DisableButtons();
                        btnNewTalent.Enabled = true;
                        listBoxTalente.SelectedItem = kategorien[i];
                    }
                }
            }
        }

        private void DisableButtons()
        {
            tbTalentname.Text = "";
            tbTalentwert.Text = "";
            btnNewTalent.Enabled = false;
            btnDeleteTalent.Enabled = false;
            btnUebernehmen.Enabled = false;
            probeAusfuehren.Enabled = false;
        }

        private void EnableButtons()
        {
            btnNewTalent.Enabled = true;
            btnDeleteTalent.Enabled = true;
            btnUebernehmen.Enabled = true;
            probeAusfuehren.Enabled = true;
        }

        private void FokusTextbox(TextBox tb)
        {
            tb.Focus();
            tb.SelectionStart = 0;
            tb.SelectionLength = tb.Text.Length;
        }

        private void waehleTalent(Talent t)
        {
            ausgewaehlt = t;
            aktuelleKategorie = t.kategorie;
            LadeTalentInfo(t);
            modifikator.Text = "" + 0;
            modifikator.Focus();
        }

        private void LadeTalenteInListbox()
        {
            listBoxTalente.Items.Clear();
            for (int i = 0; i < 7; i++)
            {
                if(i!=0) listBoxTalente.Items.Add("");
                listBoxTalente.Items.Add(kategorien[i].ToUpper());
                DruckeTalenteNachKategorie(i);
            }
        }
        
        private void DruckeTalenteNachKategorie(int kategorie)
        {
            foreach (Talent t in talente)
            {
                if (t.kategorie == kategorie)
                {
                    listBoxTalente.Items.Add(t);
                }
                if (t.kategorie > kategorie)
                    break;
            }
        }

        private void LadeTalentInfo(Talent t)
        {
            tbTalentname.Text = t.name;
            tbTalentwert.Text = "" + t.talentwert;
            cbAttr01.SelectedItem = t.attr01;
            cbAttr02.SelectedItem = t.attr02;
            cbAttr03.SelectedItem = t.attr03;

            TextBox attr01 = this.Controls.Find(t.attr01, true).FirstOrDefault() as TextBox;
            wuerfelAttr01 = Convert.ToInt32(attr01.Text);
            TextBox attr02 = this.Controls.Find(t.attr02, true).FirstOrDefault() as TextBox;
            wuerfelAttr02 = Convert.ToInt32(attr02.Text);
            TextBox attr03 = this.Controls.Find(t.attr03, true).FirstOrDefault() as TextBox;
            wuerfelAttr03 = Convert.ToInt32(attr03.Text);
            talentwert = t.talentwert;
        }

        private void btnUebernehmen_Click(object sender, EventArgs e)
        {
            if (ausgewaehlt == null)
            {
                TalentNeu(aktuelleKategorie);
            }
            ausgewaehlt.name = tbTalentname.Text;
            try
            {
                ausgewaehlt.talentwert = Convert.ToInt32(tbTalentwert.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ungültiger Wert: Talentwert");
                FokusTextbox(tbTalentwert);
                return;
                throw;
            }
            ausgewaehlt.attr01 = cbAttr01.SelectedItem as string;
            ausgewaehlt.attr02 = cbAttr02.SelectedItem as string;
            ausgewaehlt.attr03 = cbAttr03.SelectedItem as string;
            ausgewaehlt.kategorie = aktuelleKategorie;

            talente.Sort();
            LadeTalenteInListbox();
            listBoxTalente.SelectedItem = ausgewaehlt;
            bearbeitet = true;
        }

        private void btnNewTalent_Click(object sender, EventArgs e)
        {
            TalentNeu(aktuelleKategorie);
            LadeTalentInfo(ausgewaehlt);
        }

        private void btnDeleteTalent_Click(object sender, EventArgs e)
        {
            TalentLoeschen(ausgewaehlt);
        }

        private void TalentNeu(int k)
        {
            List<Talent> neueTalente = talente.FindAll(t => t.name.Contains("Neues Talent"));
            int i = neueTalente.Count+1;

            ausgewaehlt = new Talent() { name = "Neues Talent"+i, attr01 = "MU", attr02 = "MU", attr03 = "MU", talentwert = 0, kategorie = k };

            talente.Add(ausgewaehlt);
            talente.Sort();
            LadeTalenteInListbox();
            listBoxTalente.SelectedItem = ausgewaehlt;
        }

        private void TalentLoeschen(Talent t)
        {
            int i = talente.FindIndex(x => x == t);
            int posListBox = listBoxTalente.SelectedIndex;
            talente.RemoveAt(i);
            LadeTalenteInListbox();
            listBoxTalente.SelectedIndex = posListBox-1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dateiname == string.Empty)
            {
                btnSaveAs.PerformClick();
            }
            else
            {
                AttributeSpeichern(pfade.dateiAttribute);
                TalenteSpeichern(pfade.dateiTalente);
                HeldSpeichern(dateiname, pfade.dateiAttribute, pfade.dateiTalente);
                MessageBox.Show("Held gespeichert!");
            }
            this.Text = $"DSA Talentprobenrechner v{versionsnummer} - {dateiname}";
            bearbeitet = false;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog speichernDialog = new SaveFileDialog();
            speichernDialog.Filter = "XML-Dateien|*.xml";
            speichernDialog.FileName = string.Empty;

            if (speichernDialog.ShowDialog() == DialogResult.OK)
            {
                SetzeDateipfade(speichernDialog.FileName);
                AttributeSpeichern(pfade.dateiAttribute);
                TalenteSpeichern(pfade.dateiTalente);
                HeldSpeichern(speichernDialog.FileName, pfade.dateiAttribute, pfade.dateiTalente);
                dateiname = speichernDialog.FileName;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (bearbeitet)
            {
                DialogResult result = MessageBox.Show("Wollen Sie die Änderungen speichern?", "Ungespeicherte Änderungen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                if (result == DialogResult.No)
                {
                    bearbeitet = false;
                }
                if (result == DialogResult.Yes)
                {
                    btnSave.PerformClick();
                }
            }

            OpenFileDialog oeffnenDialog = new OpenFileDialog();
            oeffnenDialog.Filter = "XML-Dateien|*.xml";
            oeffnenDialog.FileName = string.Empty;

            if (oeffnenDialog.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetDirectoryName(oeffnenDialog.FileName);
                SetzeDateipfade(oeffnenDialog.FileName);
                AttributeAuslesen(pfade.dateiAttribute);
                LadeAttributeInTB();
                TalenteAuslesen(pfade.dateiTalente);
                HeldAuslesen(oeffnenDialog.FileName);
                dateiname = oeffnenDialog.FileName;
                this.Text = $"DSA Talentprobenrechner v{versionsnummer} - {dateiname}";
            }
        }

        private void TalenteSpeichern(string path)
        {
            XmlSerializer serial = new XmlSerializer(typeof(List<Talent>));
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, talente);
                //MessageBox.Show("Talente gespeichert");
            }
        }
        
        private void HeldSpeichern(string path, string attribute, string talente)
        {
            using (StreamWriter dateiHeld = new StreamWriter(path))
            {
                dateiHeld.WriteLine(heldenname);
                dateiHeld.WriteLine(attribute);
                dateiHeld.WriteLine(talente);
            }
        }

        private void AttributeSpeichern(string path)
        {
            TextBox[] tbAttribute = { MU, KL, IN, CH, FF, GE, KO, KK };
            Array.Clear(attribute, 0, attribute.Length);
            for (int i = 0; i < 8; i++)
            {
                attribute[i] = Convert.ToInt32(tbAttribute[i].Text);
            }

            XmlSerializer serial = new XmlSerializer(typeof(int[]));
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, attribute);
            }
        }

        private void SetzeDateipfade(string dateipfad)
        {
            string path = Path.GetDirectoryName(dateipfad);
            string dateiname = Path.GetFileNameWithoutExtension(dateipfad);
            pfade.dateiAttribute = path + "\\" + dateiname + "_attribute.xml";
            pfade.dateiTalente = path + "\\" + dateiname + "_talente.xml";
        }

        private void TalenteAuslesen(string path) 
        {
            XmlSerializer serial = new XmlSerializer(typeof(List<Talent>));
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                talente = serial.Deserialize(fs) as List<Talent>;
            }
            aktuelleKategorie = 0;
            LadeTalenteInListbox();
            listBoxTalente.SelectedIndex = 0;
        }

        private void AttributeAuslesen(string path)
        {
            XmlSerializer serial = new XmlSerializer(typeof(int[]));
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                attribute = (serial.Deserialize(fs)) as int[];
            }
        }

        private void HeldAuslesen(string path)
        {
            using (StreamReader dateiHeld = new StreamReader(path))
            {
                heldenname = dateiHeld.ReadLine();
            }
            tbHeldenname.Text = heldenname;
            bearbeitet = false;
        }

        private void LadeAttributeInTB()
        {
            TextBox[] tbAttribute = { MU, KL, IN, CH, FF, GE, KO, KK };
            for (int i=0; i<8; i++)
            {
                tbAttribute[i].Text = "" + attribute[i];
            }
        }

        private void ProbeAusfuehren_Click(object sender, EventArgs e)
        {
            if (ausgewaehlt!= null)
            {
                patzerzaehler = 0;
                int mod;
                try
                {
                    mod = Convert.ToInt32(modifikator.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ungültiger Wert: Modifikator");
                    FokusTextbox(modifikator);
                    return;
                    throw;
                }
                int tawRest = talentwert;
                int[] attribute = { wuerfelAttr01, wuerfelAttr02, wuerfelAttr03 };

                //Probe ausführen
                tawRest = WuerfelnHausregel(attribute, tawRest, mod);
                ResultatAusgeben(tawRest);

                //Attribute wieder auf Originalwert zurücksetzen
                LadeTalentInfo(ausgewaehlt); 
            }
        }

        private int WuerfelnHausregel(int[] attribute, int taw, int mod)
        {
            Label[] ausgabenWurf = { ausgabeWurf01, ausgabeWurf02, ausgabeWurf03 };
            Label[] ausgabenTaw = { tawRest01, tawRest02, tawRest03 };
            int[] wuerfe = new int[3];
            int[] modifikatoren = { 0, 0, 0 };

            // drei mal Würfeln und in Array speichern
            for (int i = 0; i < 3; i++)
            {
                wuerfe[i] = r.Next(1, 21);
                if (wuerfe[i] == 20) patzerzaehler++; 
            }

            // modifikator auf drei ganze Zahlen aufteilen und in array speichern
            if(mod != 0)
            {
                double modEinzelnD = (double)mod / 3;
                int modEinzeln = (int)Math.Round((double)modEinzelnD);
                for (int i = 0; i < 3; i++)
                {
                    modifikatoren[i] = modEinzeln;
                }
                if (modEinzeln * 3 < mod) modifikatoren[0] = modifikatoren[0] + 1;
                if (modEinzeln * 3 > mod) modifikatoren[2] = modifikatoren[2] - 1;
            }
            
            // beide Arrays (Würfe und Attribute) absteigend sortieren
            Array.Sort(wuerfe);
            Array.Reverse(wuerfe);
            Array.Sort(attribute);
            Array.Reverse(attribute);

            // modifikatoren von den Attributen abziehen
            for (int i = 0; i < 3; i++)
            {
                attribute[i] = attribute[i] - modifikatoren[i];
            }

            // je Würfelwurf vom Attributswert abziehen
            for (int i = 0; i < 3; i++)
            {
                int delta = attribute[i] - wuerfe[i];
                //wenn negativ: Differenz vom Talentwert abziehen
                if (delta < 0) taw += delta; 

                ausgabenWurf[i].Text = "" + wuerfe[i] + " gegen " + attribute[i];
                ausgabenTaw[i].Text = "" + taw;
            }

            return taw;
        }

        /*private int Wuerfeln(int attr, int taw, int i)
        {
            Label[] ausgabenWurf = { ausgabeWurf01, ausgabeWurf02, ausgabeWurf03 };
            Label[] ausgabenTaw = { tawRest01, tawRest02, tawRest03 };
            //int wurf = 20;
            int wurf = r.Next(1, 21);
            int delta = wurf - attr;

            if (wurf == 20) 
            { patzerzaehler++; }

            if (wurf > attr)
            { taw -= delta; }

            ausgabenWurf[i].Text = ""+wurf +" (gegen " +attr +")";
            ausgabenTaw[i].Text = ""+taw;

            return taw;
        }
        */

        private void btn_w6_Click(object sender, EventArgs e)
        {
            int wuerfelArt = 6;
            Wuerfelwurf(wuerfelArt);
        }

        private void btn_w20_Click(object sender, EventArgs e)
        {
            int wuerfelArt = 20;
            Wuerfelwurf(wuerfelArt);
        }

        private void Wuerfelwurf(int wuerfelArt)
        {
            int anzahl = Convert.ToInt32(wuerfelAnzahl.Value);
            int mod = Convert.ToInt32(wuerfelMod.Value);
            int[] wuerfe = new int[anzahl];
            string ergebnisse = String.Empty;
            int kumuliert = 0;

            for (int i = 0; i < anzahl; i++)
            {
                wuerfe[i] = r.Next(1, wuerfelArt + 1);
                kumuliert += wuerfe[i];
                if (i == 0)
                { ergebnisse = "" + wuerfe[i]; }
                else
                { ergebnisse += (", " + wuerfe[i]); }
            }

            kumuliert += mod;
            string geworfen = "" + anzahl + "W" + wuerfelArt;
            string historie = "" + geworfen + "   " + ergebnisse + "   (" + kumuliert +")";
            ausgabe.Items.Add(historie);
            ausgabeKumuliert.Text = "" + kumuliert;
            ausgabeWuerfelart.Text = "" + geworfen;
            ausgabeWuerfe.Text = ergebnisse;
        }

        private void tbHeldenname_TextChanged(object sender, EventArgs e)
        {
            heldenname = tbHeldenname.Text;
            bearbeitet = true;
        }

        private void TalentprobenRechnerv03_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bearbeitet)
            {
                DialogResult result = MessageBox.Show("Wollen Sie die Änderungen speichern?", "Ungespeicherte Änderungen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                if (result == DialogResult.No)
                {
                    bearbeitet = false;
                    this.Close();
                }
                if (result == DialogResult.Yes)
                {
                    btnSave.PerformClick();
                }
            }
        }

        private void ResultatAusgeben(int uebrig)
        {
            int mod = Convert.ToInt32(modifikator.Text);
            int erschwernis = 0;

            if (mod < 0)
            { erschwernis = talentwert + mod; }
            
            if (patzerzaehler < 2)
            {
                if (uebrig >= erschwernis)
                {
                    resultat.BackColor = Color.LightGreen;
                    if (uebrig <= 0) 
                    { 
                        resultat.Text = "Geschafft!";
                        listBox1.Items.Add(ausgewaehlt.name.PadRight(30, ' ') + "\tÜbrige Punkte: 0");
                    }
                    else 
                    { 
                        resultat.Text = "Geschafft! " + uebrig + " übrig";
                        listBox1.Items.Add(ausgewaehlt.name.PadRight(30,' ') + "\tÜbrige Punkte: " + Convert.ToString(uebrig));
                    }
                }
                else
                {
                    resultat.Text = "Verkackt!";
                    resultat.BackColor = Color.Salmon;
                    listBox1.Items.Add(ausgewaehlt.name.PadRight(30, ' ') + "\tverkackt");
                }
            }
            else
            {
                resultat.Text = "PATZER!";
                resultat.BackColor = Color.Red;
                listBox1.Items.Add(ausgewaehlt.name.PadRight(30, ' ') + " verpatzt");
            }
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            listBox1.SetSelected(listBox1.Items.Count - 1, false);
        }

        private void tbTalentname_Enter(object sender, EventArgs e)
        {
            tbTalentname.SelectionStart = 0;
            tbTalentname.SelectionLength = tbTalentname.Text.Length;
        }

        private void tbTalentname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUebernehmen.PerformClick();
            }
        }

        private void tbTalentwert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUebernehmen.PerformClick();
            }
        }
    }
}
