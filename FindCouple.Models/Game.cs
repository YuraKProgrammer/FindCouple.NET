﻿using FindCouple.Models.Generators;

namespace FindCouple.Models
{
    public class Game
    {
        public GameField Field;
        public FieldGenerator fieldGenerator = new FieldGenerator();
        public bool IsOneCellOpened = false;
        public int openedX = -1;
        public int openedY = -1;

        public Game(int size)
        {
            Field = fieldGenerator.Generate(size);
        }

        public void OpenCell(int x, int y)
        {
            if (x != openedX || y != openedY)
            {
                if (IsOneCellOpened == false)
                {
                    Field.cells[x, y].IsOpen = true;
                    IsOneCellOpened = true;
                    openedX = x;
                    openedY = y;
                }
                else
                {
                    if (Field.cells[x, y].Unit.UnitImageType == Field.cells[openedX, openedY].Unit.UnitImageType)
                    {
                        Field.cells[x, y].IsOpen = false;
                        Field.cells[openedX, openedY].IsOpen = false;
                        Field.cells[x, y].IsSolved = true;
                        Field.cells[openedX, openedY].IsSolved = true;
                    }
                    else
                    {
                        Field.cells[openedX, openedY].IsOpen = false;
                        Field.cells[x, y].IsOpen = false;
                    }
                    IsOneCellOpened = false;
                }
            }
        }
    }
}