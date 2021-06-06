using System;
using System.Collections.Generic;
using op_lab7.Figures;


namespace op_lab7
{
    public class Board
    {
        public int size = 8;
        public Cell[,] board;
        private List<Figure> figures;

        //мутим поле
        public Board()
        {
            board = new Cell[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = new Cell(j, i);
                }
            }
        }

        public void AddFigure(Figure figure)
        {
            this.figures.Add(figure);
            CheckCells();
        }

        private void CheckCells()
        {
            //проверь точность
            foreach (Figure figure in figures)
            {
                var a = figure.GetPosition();
                board[a.y, a.x].occupied = true;
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
        
        public List<Cell> GetDiagonals(Cell cell)
        {
            var result = new List<Cell>();

            int xStart = cell.x;
            int yStart = cell.y;

            #region диагональ слева направо вниз
            while (xStart != 0 && yStart != 0)
            {
                yStart--;
                xStart--;
            }

            for (int x = xStart; x < size; xStart++)
            {
                if (!cell.Equals(board[yStart, x]))
                {
                    var cellToHighlite = board[yStart, x];
                    cellToHighlite.Highlite(true);
                    result.Add(cellToHighlite);
                }
                yStart++;
            }
            #endregion


            #region диагональ справа налево вниз
            xStart = cell.x;
            yStart = cell.y;

            while (xStart != 8 && yStart != 0)
            {
                yStart--;
                xStart++;
            }

            for (int y = yStart; y < size; yStart++)
            {
                if (!cell.Equals(board[y, xStart]))
                {
                    var cellToHighlite = board[y, xStart];
                    cellToHighlite.Highlite(true);
                    result.Add(cellToHighlite);
                }
                xStart--;
            }
            #endregion

            return result;
        }

        public List<Cell> GetVertAndHor(Cell cell)
        {
            var result = new List<Cell>();
            
            //вертикаль
            for (int y = 0; y < size; y++)
                if (y != cell.y)
                {
                    var cellToHighlite = board[y, cell.x];
                    cellToHighlite.Highlite(true);
                    result.Add(cellToHighlite);
                }

            //горизонталь
            for (int x = 0; x < size; x++)
                if (x != cell.x)
                {
                    var cellToHighlite = board[cell.y, x];
                    cellToHighlite.Highlite(true);
                    result.Add(cellToHighlite);
                }

            return result;
        }
    }
}
