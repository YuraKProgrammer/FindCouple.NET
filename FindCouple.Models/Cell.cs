using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCouple.Models
{
    public class Cell
    {
        public Unit Unit { get; set; }

        public bool IsOpen { get; set; }

        public bool IsSolved { get; set; }

        public Cell(Unit unit)
        {
            Unit = unit;
            IsOpen = false;
            IsSolved = false;
        }
    }
}
