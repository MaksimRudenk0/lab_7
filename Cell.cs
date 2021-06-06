using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace op_lab7
{
    public class Cell
    {

        public int colNumber;
        public int rowNumber;
        public bool? occupied;

        public Cell(int x, int y, bool? occupied = false)
        {
            //проверь 
            if(x>7 || y>7 || x<0 || y<0)
                return;
            rowNumber = x;
            colNumber = y;
            this.occupied = occupied;
        }

        public override bool Equals(Object cell)
        {
            //Check for null and compare run-time types.
            if ((cell == null) || !this.GetType().Equals(cell.GetType()))
            {
                return false;
            }
            else
            {
                Cell c = (Cell)cell;
                return (colNumber == c.colNumber) && (rowNumber == c.rowNumber);
            }
        }
    }
}
