using DSASkillchecks;
using System.Collections.Generic;


namespace DSASkillchecks
{
    class Hero
    {
        public string name { get; set; }
        public int ini { get; set; }
        public List<Talent> talents;
        public int[] attributes;

        public Hero(string name, List<Talent> talents, int ini = 0, int[] attributes = null)
        {
            this.name = name;
            this.talents = talents;
            this.ini = ini;
            this.attributes = attributes ?? new int[8];
        }
    }
}
