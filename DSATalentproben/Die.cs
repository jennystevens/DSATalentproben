using System;
using System.Collections.Generic;

namespace DSASkillchecks
{
    public class Die
    {
        public int type;

        public struct rollResult
        {
            public int accumulated;
            public int mod;
            public List<int> rolls;
        }

        public Die(int type = 6)
        {
            this.type = type;
        }

        public rollResult Roll(Random r, int amount = 1, int mod = 0)
        {
            rollResult result = new rollResult
            {
                accumulated = mod,
                mod = mod,
                rolls = new List<int>()
            };

            for (int i = 0; i < amount; i++)
            {
                int roll = r.Next(1, this.type + 1);
                result.rolls.Add(roll);
                result.accumulated += result.rolls[i];
            }

            return result;
        }

    }
}
