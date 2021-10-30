using System;

namespace DSASkillchecks
{
    public class Talent : IComparable
    {
        public string name { get; set; }
        public string attr01 { get; set; }
        public string attr02 { get; set; }
        public string attr03 { get; set; }
        public int talentValue { get; set; }
        public int category { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) 
            {  return 1; }

            if (obj.GetType() == typeof(Talent))
            {
                Talent tempTalent = (Talent)(obj);
                var ret = this.category.CompareTo(tempTalent.category);
                if (ret == 0)
                {
                    ret = this.name.CompareTo(tempTalent.name);
                }
                return ret;
            } 
            else  
            {
                throw new Exception("obj is not a Talent " + obj.GetType());
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
            return this.name;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
