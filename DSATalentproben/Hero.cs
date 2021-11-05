using System;
using System.Collections.Generic;


namespace DSASkillchecks
{
    public class Hero
    {
        public string name { get; set; }
        public List<Talent> talents;
        public Dictionary<string, int> attr;
        public Dictionary<string, int> combat;
        public struct skillcheckResult
        {
            public int[] rolls;
            public int[] attributes;
            public int[] talentValueRemainder;
            public int fumbleCounter;
        }

        public Hero(string name)
        {
            this.name = name;
            talents = new List<Talent>();
            attr = new Dictionary<string, int> { { "MU", 8 }, { "KL", 8 }, { "IN", 8 }, { "CH", 8 }, { "FF", 8 }, { "GE", 8 }, { "KO", 8 }, { "KK", 8 } };
            combat = new Dictionary<string, int> { { "initiative", 0 }, { "ausweichen", 0 }, { "regLE", 0 }, { "regAE", 0 },{"LE",0},{"AE",0 } };
        }

        public skillcheckResult RollHouserule(Random r, Talent talent, int mod)
        {
            skillcheckResult result = new skillcheckResult();
            int[] attributes = { this.attr[talent.attr01], this.attr[talent.attr02], this.attr[talent.attr03] };
            int[] talentValueRemainder = new int[3];
            int[] rolls = new int[3];
            int[] modifiers = { 0, 0, 0 };
            int talentValue = talent.talentValue;
            int fumbleCounter = 0;

            // roll three times and save to rolls array
            for (int i = 0; i < 3; i++)
            {
                rolls[i] = r.Next(1, 21);
                if (rolls[i] == 20) fumbleCounter++;
            }

            // split modifier into three integers and save to array modifiers
            if (mod != 0)
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
                talentValueRemainder[i] = talentValue;
            }

            result.attributes = attributes;
            result.rolls = rolls;
            result.talentValueRemainder = talentValueRemainder;
            result.fumbleCounter = fumbleCounter;

            return result;
        }
    }
}
