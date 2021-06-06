using System;
using System.Collections.Generic;
using System.Text;

namespace op_lab7
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
        public Figure(string name, int x, int y, Board board, int? color = 1)
        {
            this.color = color;
            this.name = name;
            this.board = board;
            this.alive = true;
            this.position = new Cell(x, y);
            switch (name)
            {
                case "Ферзь":
                    //добавить иконки
                    piece = new UnicodeEncoding();
                    break;
                case "Конь":
                    //добавить иконки
                    piece = new UnicodeEncoding();
                    break;
                case "Пешка":
                    //добавить иконки
                    piece = new UnicodeEncoding();
                    break;
            }

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

    }
}
//https://en.wikipedia.org/wiki/Chess_symbols_in_Unicode