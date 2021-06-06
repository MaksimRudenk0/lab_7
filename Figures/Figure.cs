using System;
using System.Collections.Generic;
using System.Text;

namespace op_lab7.Figures
{
    public abstract class Figure
    {
        //1-white
        //2-black
        //default white
        protected Board board;
        public int? color;
        protected bool alive;
        public string name;
        protected Cell position;
        protected UnicodeEncoding piece;
        protected List<Figure> possibleKills;
        protected List<Cell> possiblePositions;

        public Figure(int x, int y, Board board, int? color = 1)
        {
            this.color = color;
            this.board = board;
            this.alive = true;
            this.position = new Cell(x, y);
            possibleKills = new List<Figure>();
        }

        public Cell GetPosition()
        {
            return position;
        }

        public List<string> GetPossibleKills()
        {
            var temp = new List<string>();
            foreach (var pk in possibleKills)
            {
                if (pk != null)
                    temp.Add(pk.name);
            }
            return temp;
        }

        public abstract void CalculatePossibleKills();

        public void SetPosition(Cell pos)
        {
            position = pos;
        }
    }
}
//https://en.wikipedia.org/wiki/Chess_symbols_in_Unicode