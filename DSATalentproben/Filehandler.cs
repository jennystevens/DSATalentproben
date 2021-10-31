using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DSASkillchecks
{
    public class Filehandler
    {
        private string _filename;
        public string Filename
        {
            get => _filename;
            set => _filename = value;
        }
        public struct Paths
        {
            public string fileAttributes { get; set; }
            public string fileTalents { get; set; }
        }

        public Filehandler()
        {
            this.Filename = string.Empty;
        }

        public void SaveTalents(string path, Hero hero)
        {
            XmlSerializer serial = new XmlSerializer(typeof(List<Talent>));
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, hero.talents);
            }
        }

        public void SaveAttributes(string path, Hero hero)
        {
            new XElement("attributes", hero.attr.Select(kv => new XElement(kv.Key, kv.Value)))
            .Save(path, SaveOptions.OmitDuplicateNamespaces);
        }

        public void SaveHero(string path, string attributes, string talents, Hero hero)
        {
            using (StreamWriter fileHero = new StreamWriter(path))
            {
                fileHero.WriteLine(hero.name);
                fileHero.WriteLine(attributes);
                fileHero.WriteLine(talents);
            }
        }

        public Paths SetFilePaths(string filepath)
        {
            Paths paths = new Paths();
            string strippedPath = Path.GetDirectoryName(filepath);
            string filename = Path.GetFileNameWithoutExtension(filepath);
            paths.fileAttributes = strippedPath + "\\" + filename + "_attribute.xml";
            paths.fileTalents = strippedPath + "\\" + filename + "_talente.xml";
            return paths;
        }

        public void ReadAttributes(string path, Hero hero)
        {
            hero.attr = XElement.Parse(File.ReadAllText(path))
                .Elements()
                .ToDictionary(k => k.Name.ToString(), v => Convert.ToInt32(v.Value));
        }

        public void ReadTalents(string path, Hero hero)
        {
            XmlSerializer serial = new XmlSerializer(typeof(List<Talent>));
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                hero.talents = serial.Deserialize(fs) as List<Talent>;
            }
        }

        public void ReadHero(string path, Hero hero)
        {
            using (StreamReader fileHero = new StreamReader(path))
            {
                hero.name = fileHero.ReadLine();
            }
        }
    }
}
