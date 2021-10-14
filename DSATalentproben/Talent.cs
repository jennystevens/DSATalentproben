using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DSATalentproben
{
    public class Talent : IComparable
    {
        public string name { get; set; }
        public string attr01 { get; set; }
        public string attr02 { get; set; }
        public string attr03 { get; set; }
        public int talentwert { get; set; }
        public int kategorie { get; set; }

        public int CompareTo(object obj)
        {
            
            if (obj == null) {  return 1; }
            if (obj.GetType() == typeof(Talent))
            {
                Talent tempTalent = (Talent)(obj);
                var ret = this.kategorie.CompareTo(tempTalent.kategorie);
                if (ret == 0)
                {
                    ret = this.name.CompareTo(tempTalent.name);
                }
                return ret;
            } 
            else  
            {
                throw new Exception("obj ist kein Talent " + obj.GetType());
            }
        }

        public override bool Equals(Object obj) 
        {
            if (obj.GetType() != typeof(Talent))
                return false;

            return CompareTo(obj) == 0;
            //return this.name.Equals((obj as Talent).name);
            //if (obj == null) return false;
            //Talent objAsTalent = obj as Talent;
            //if (objAsTalent == null) return false;
            //else return Equals(objAsTalent);
        }

        public bool Equals(Talent other)
        {
            if (other == null) return false;
            return (this.name.Equals(other.name));
        }

        public override string ToString()
        {
            //string taw = this.talentwert.ToString().PadLeft(2, '0');
            //return $"{taw} _ {this.name}";
            return this.name;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetTalentwert()
        {
            return this.talentwert;
        }
    }
}
