using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    internal class DiceRoller
    {
        private Random random;

        public DiceRoller()
        {
            random = new Random();
        }

        public int[] SimulateRolls(int numRolls)
        {
            int[] results = new int[13];

            for (int iNum = 0; iNum < numRolls; iNum++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                results[sum]++;
            }

            return results;
        }
    }
}
