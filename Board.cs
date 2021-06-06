using System;
using System.Collections.Generic;


namespace op_lab7
{
    public class Board
    {
        public int size =8;
        public Cell[,] board ;
        private List<Figure> figures;

        //мутим поле
        public Board()
        {
            board = new Cell[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = new Cell(i, j);
                }
            }
        }

        public void AddFigures(List<Figure> figures)
        {
            this.figures.AddRange(figures);
            CheckCells();
        }

        private void CheckCells()
        {
            //проверь точность
            foreach (Figure figure in figures)
            {
                var a = figure.GetPosition();
                board[a.rowNumber, a.colNumber].occupied = true;
            }
        }

        public Figure GetFigureOnCell(Cell cell)
        {
            foreach (var figure in figures)
            {
                if (figure.GetPosition().Equals(cell))
                    return figure;
            }
            return null;
        }
    }
}
