using System;
using System.Collections.Generic;
using op_lab7;

namespace op_lab7.Figures
{
    class Knight : Figure
    {
        public Knight(int x, int y, Board board) : base(x, y, board)
        {
            name = "Король";
        }

        public override void CalculatePossibleKills()
        {
            //чикнуть на правильность направления хода
            var availablePoss = new List<Cell>()
            {
                new Cell(position.x + 2, position.y + 1),
                new Cell(position.x + 1, position.y + 2),
                new Cell(position.x - 1, position.y + 2),
                new Cell(position.x - 2, position.y + 1),
                new Cell(position.x - 2, position.y - 1),
                new Cell(position.x - 1, position.y - 2),
                new Cell(position.x + 2, position.y + 1),
                new Cell(position.x + 1, position.y - 2),
                new Cell(position.x + 2, position.y - 1),
            };

            possibleKills = new List<Figure>();
            foreach (var pos in availablePoss)
            {
                possibleKills.Add(board.GetFigureOnCell(pos));
            }
        }
    }
}