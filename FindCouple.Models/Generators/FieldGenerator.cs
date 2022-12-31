using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCouple.Models.Generators
{
    public class FieldGenerator
    {
        public UnitGenerator unitGenerator = new UnitGenerator();
        public Random random = new Random();
        public GameField Generate(int size)
        {
            Cell[,] cells = new Cell[size, size];
            while (CheckHoles(cells,size))
            {
                Unit unit = unitGenerator.GenerateRandom();
                Cell cell1 = new Cell(unit);
                Cell cell2 = new Cell(unit);
                int x1 = random.Next(size);
                int y1 = random.Next(size);
                while (cells[x1, y1] != null)
                {
                    x1 = random.Next(size);
                    y1 = random.Next(size);
                }
                cells[x1, y1] = cell1;
                int x2 = random.Next(size);
                int y2 = random.Next(size);
                while (cells[x2,y2]!=null)
                {
                    x2 = random.Next(size);
                    y2 = random.Next(size);
                }
                cells[x2, y2] = cell2;
            }
            var gf = new GameField(size);
            gf.cells = cells;
            return gf;
        }

        private bool CheckHoles(Cell[,] cells,int size)
        {
            for (var x=0; x<size; x++)
            {
                for (var y=0; y<size; y++)
                {
                    if (cells[x,y] == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
