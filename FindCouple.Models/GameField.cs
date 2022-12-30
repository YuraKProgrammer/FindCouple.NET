using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCouple.Models
{
    public class GameField
    {
        public int Size;

        public Cell[,] cells { get; set; }

        public GameField(int size)
        {
            Size = size;
            cells = new Cell[size, size];
        }
    }
}
