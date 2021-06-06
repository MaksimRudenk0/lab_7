using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace op_lab7.Figures
{
    class Queen : Figure
    {
        public Queen(string name, int x, int y, Board board) : base(name, x, y, board) { }

        public override void CalculatePossibleKills()
        {
            List<Cell> possiblePositions = new List<Cell>();
            possiblePositions.AddRange(board.GetDiagonals(position));
            possiblePositions.AddRange(board.GetVertAndHor(position));

            possibleKills = new List<Figure>();
            foreach (var pos in possiblePositions)
            {
                var figure = board.GetFigureOnCell(pos);
                if(figure != null)
                    possibleKills.Add(figure);
            }

        }
    }
}