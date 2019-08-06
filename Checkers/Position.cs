using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Checkers
{
    public struct Position
    {
        public int row { get; private set; }
        public int col { get; private set; }
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
}
