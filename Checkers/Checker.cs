using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Checkers
{
    public class Checker
    {
        public string Symbol { get; private set; }
        public Color Team { get; private set; }
        public Position Position { get; set; }

        public Checker(Color team, int row, int col)
        {
                if (player == Color.Black)
                {
                    int symbol = int.Parse("25CB", 
                        System.Globalization.NumberStyles.HexNumber);
                    Symbol = char.ConvertFromUtf32(symbol);
                    Team = Color.Black;
                }
                else
                {
                    int symbol = int.Parse("25CF", 
                        System.Globalization.NumberStyles.HexNumber);
                    Symbol = char.ConvertFromUtf32(symbol);
                    Team = Color.White;
                }
            ///Set a position for eack new checker that is instantiated.
        }
    }
}