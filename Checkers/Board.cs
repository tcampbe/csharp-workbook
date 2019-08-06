using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Checkers
{
    public class Board
    {
        public List<Checker> checkers;
        public Board()
        {
            checkers = new List<Checker>();
            for (int r = 0; r < 3; r++)
            {
                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
                    checkers.Add(c);
                }
                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.Black, 5 + r, (r) % 2 + i);
                    checkers.Add(c);
                }
                ///NOTE: Can we combine the two "for" loops above into one "for" loop?
            }
        }

        public Checker GetChecker(Position pos)
        {
            foreach (Checker c in checkers)
            {
                //Fill in the blanks in the if statement below
                if (c.Position.Row == (______) && c.Position.Column == (______))
                {
                    return c;
                }
            }
            //make sure all code paths return a value; what happens if the above condition is not met.  Can the method return a Checker?
        }

        public void RemoveChecker(Checker checker)
        {
            //Fill in the blank in the logic
            if (checker(___) null)
            {
                //Remove the checker from our list of checkers.
            }
        }

        public void MoveChecker(Checker checker, Position dest)
        {
            Checker c = new Checker(checker.Team, destination.Row, destination.Column);
            //Add the checker to our list of checkers.
            checkers.Remove(checker);
        }
    }
}