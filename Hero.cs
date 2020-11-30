using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hero : Character
{
    public Hero(int X, int Y, int HP, int MAXHP, int DAMAGE) : base(X, Y)
    {
        DAMAGE = 2;
        HP = 10;
        MAXHP = HP;
    }


    public override Movement returnMove(Movement move = Movement.None)
    {

        while (ArrVision[0].GetType().Equals(nameof(Empty)))
        {
            switch (move)
            {          
                case Movement.Up:
                    Y -= 1;
                    break;

                case Movement.Down:
                    Y += 1;
                    break;

                case Movement.Left:
                    X -= 1;
                    break;

                case Movement.Right:
                    X += 1;
                    break;
            }
            return move;
        }
    }
    public override string ToString()

    {
        return "Player Stats:, HP: HP / Max HP, Damage: 2,[X,Y]";
    }
}
