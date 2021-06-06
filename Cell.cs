using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace op_lab7
{
    public class Cell
    {
        private bool highlited;
        public int x;
        public int y;
        public bool? occupied;

        public Cell(int x, int y, bool? occupied = false)
        {
            if(x>7 || y>7 || x<0 || y<0)
                return;
            this.y = x;
            this.x = y;
            this.occupied = occupied;
        }

        public override bool Equals(Object cell)
        {
            if ((cell == null) || !this.GetType().Equals(cell.GetType()))
            {
                return false;
            }
            else
            {
                Cell c = (Cell)cell;
                return (x == c.x) && (y == c.y);
            }
        }

        public void Highlite(bool value) => highlited = value;
    }
}
