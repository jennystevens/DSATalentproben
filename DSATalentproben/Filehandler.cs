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

        public Filehandler()
        {
            this.Filename = string.Empty;
        }

        public void SaveHeroFile(string path, Hero hero)
        {
            XElement heroStats =
                new XElement("Hero",
                    new XElement("heroname", hero.name),
                    new XElement("attributes", hero.attr.Select(kv => new XElement(kv.Key, kv.Value)))
                );
            XElement Xtalents = GatherTalents(hero.talents);
            heroStats.Add(Xtalents);
            heroStats.Save(path);
        }

        XElement GatherTalents(List<Talent> talents)
        {
            XElement Xtalents = new XElement("talents");
            foreach (Talent t in talents)
            {
                XElement talent = new XElement("talent",
                        new XElement("name", t.name),
                        new XElement("attr01", t.attr01),
                        new XElement("attr02", t.attr02),
                        new XElement("attr03", t.attr03),
                        new XElement("talentValue", t.talentValue),
                        new XElement("category", t.category)
                    );
                Xtalents.Add(talent);
            }
            return Xtalents;
        }

        public Hero LoadHeroFile(string path, Hero hero)
        {
            XElement heroStats = XElement.Load(path);
            hero.name = LoadName(heroStats);
            hero.attr = LoadAttributes(heroStats);
            hero.talents = LoadTalents(heroStats);
            return hero;
        }

        string LoadName(XElement heroStats)
        {
            IEnumerable<XElement> heroname = from descendant in heroStats.Descendants("heroname")
                                             select descendant;
            string name = heroname.ElementAt(0).Value.ToString();
            return name;
        }

        Dictionary<string, int> LoadAttributes(XElement heroStats)
        {
            IEnumerable<XElement> attr = from descendant in heroStats.Descendants("attributes")
                                         select descendant;
            Dictionary<string, int> attributes = attr.Elements().ToDictionary(k => k.Name.ToString(), v => Convert.ToInt32(v.Value));
            return attributes;
        }

        List<Talent> LoadTalents(XElement heroStats)
        {
            List<Talent> talents = new List<Talent>();
            IEnumerable<XElement> Xtalents = from talent in heroStats.Descendants("talents")
                                                  select talent;

            foreach (XElement element in Xtalents)
            {
                IEnumerable<XElement> allTalents = element.Descendants("talent");

                foreach (XElement talent in allTalents)
                {
                    Talent t = new Talent
                    {
                        name = talent.Element("name").Value,
                        attr01 = talent.Element("attr01").Value,
                        attr02 = talent.Element("attr02").Value,
                        attr03 = talent.Element("attr03").Value,
                        talentValue = Convert.ToInt32(talent.Element("talentValue").Value),
                        category = Convert.ToInt32(talent.Element("category").Value)
                    };
                    talents.Add(t);
                }
            }
            return talents;
        }
    }
}
