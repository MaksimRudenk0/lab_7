using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace op_lab7.Fifure
{
    class Queen : Figure
    {
        public Queen(string name, int x, int y, Board board) : base(name, x, y, board) { }

        public override void CalculatePossibleKills()
        {
            //чикнуть на правильность направления хода
            var availablePoss = new List<Cell>()
            {
                new Cell(position.colNumber + 2, position.rowNumber + 1),
                new Cell(position.colNumber + 1, position.rowNumber + 2),
                new Cell(position.colNumber - 1, position.rowNumber + 2),
                new Cell(position.colNumber - 2, position.rowNumber + 1),
                new Cell(position.colNumber - 2, position.rowNumber - 1),
                new Cell(position.colNumber - 1, position.rowNumber - 2),
                new Cell(position.colNumber + 2, position.rowNumber + 1),
                new Cell(position.colNumber + 1, position.rowNumber - 2),
                new Cell(position.colNumber + 2, position.rowNumber - 1),
            //     public void ShowDiagonal(int x, int y, bool isOneStep = false)
            //{
            //    int j = y + 1;
            //    for (int i = x - 1; i >= 0; i--)
            //    {
            //        if (InsideBorder(i, j))
            //        {
            //            if (!DeterminePath(i, j))
            //                break;
            //        }
            //        if (j < 7)
            //            j++;
            //        else break;

            //        if (isOneStep)
            //            break;
            //    }

            //    j = y - 1;
            //    for (int i = x - 1; i >= 0; i--)
            //    {
            //        if (InsideBorder(i, j))
            //        {
            //            if (!DeterminePath(i, j))
            //                break;
            //        }
            //        if (j > 0)
            //            j--;
            //        else break;

            //        if (isOneStep)
            //            break;
            //    }

            //    j = y - 1;
            //    for (int i = x + 1; i < 8; i++)
            //    {
            //        if (InsideBorder(i, j))
            //        {
            //            if (!DeterminePath(i, j))
            //                break;
            //        }
            //        if (j > 0)
            //            j--;
            //        else break;

            //        if (isOneStep)
            //            break;
            //    }

            //    j = y + 1;
            //    for (int i = x + 1; i < 8; i++)
            //    {
            //        if (InsideBorder(i, j))
            //        {
            //            if (!DeterminePath(i, j))
            //                break;
            //        }
            //        if (j < 7)
            //            j++;
            //        else break;

            //        if (isOneStep)
            //            break;
            //    }
            //}
        };

            possibleKills = new List<Figure>();
            foreach (var pos in availablePoss)
            {
                //сделать проверку на цвет
                possibleKills.Add(board.GetFigureOnCell(pos));
            }
        }
    }
}
