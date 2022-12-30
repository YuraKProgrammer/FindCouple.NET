using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCouple.Models
{
    public class Unit
    {
        public UnitImageType UnitImageType { get; set; }

        public Unit(UnitImageType unitImageType)
        {
            UnitImageType = unitImageType;
        }
    }
}
