using System;
using System.Collections.Generic;
using System.Text;
using op_lab7;

namespace op_lab7.Figures
{
    class Pawn : Figure
    {
        public Pawn(int x, int y, Board board) : base(x, y, board)
        {
            name = "Пешка";
        }

        public override void CalculatePossibleKills()
        {
            int xStep = 0;
            switch (color)
            {
                case 1:
                    xStep = 1;
                    break;
                case 2:
                    xStep = -1;
                    break;
            }

            //чикнуть на правильность направления хода
            var availablePoss = new List<Cell>()
            {
                new Cell(position.x + 1, position.y + xStep),
                new Cell(position.x + 1, position.y + xStep),
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