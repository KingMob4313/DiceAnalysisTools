using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceAnalysis
{
    class DSix
    {
        int dieRoll;
        public int RollDSix()
        {
            Random randomSeed = new Random();
            int dieRoll = randomSeed.Next(1, 6);
            return dieRoll;
        }
    }


}
