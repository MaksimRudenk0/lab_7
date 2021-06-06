using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using op_lab7.Figures;

namespace op_lab7
{
    public static class FiguresFactory
    {
        public static Figure CreateFigure(string fName, Board board)
        {
            switch (fName)
            {
                case "Пешка":
                    return new Pawn(0,0, board);
                case "Конь":
                    return new Knight(0, 0, board);
                case "Ферзь":
                    return new Queen(0, 0, board);
                default:
                    return null;
            }
        }
    }
}
