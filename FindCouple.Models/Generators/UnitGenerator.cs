using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCouple.Models.Generators
{
    public class UnitGenerator
    {
        Random random = new Random();
        public Unit GenerateRandom()
        {
            return new Unit(IntToUnitImageType(random.Next(9)));
        }

        private UnitImageType IntToUnitImageType(int i)
        {
            switch (i)
            {
                default: return UnitImageType.T1;
                case 1: return UnitImageType.T1;
                case 2: return UnitImageType.T2;
                case 3: return UnitImageType.T3;
                case 4: return UnitImageType.T4;
                case 5: return UnitImageType.T5;
                case 6: return UnitImageType.T6;
                case 7: return UnitImageType.T7;
                case 8: return UnitImageType.T8;
            }
        }
    }
}
