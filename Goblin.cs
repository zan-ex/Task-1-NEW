using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Goblin : Enemy
{
    public Goblin(int X, int Y, int enemyHP, int enemyDamage, int symbol) : base(X, Y, 10, 1)
    {
        enemyHP = 10;
        enemyDamage = 1;
        symbol = 'G';
    }
    Random rnd = new Random();
    public override Movement returnMove(Movement move = 0)
    {
        int rndNum = rnd.Next(0, 4);
        while (!ArrVision[0].GetType().Equals(nameof(Empty)))
        {
            rndNum = rnd.Next(0, 4);
        }

        switch (rndNum) //goblin movement 
        {
            case 0:
                move = Movement.Up;
                break;
            case 1:
                move = Movement.Down;
                break;
            case 2:
                move = Movement.Left;
                break;
            case 3:
                move = Movement.Right;
                break;
            case 4:
                move = Movement.None;
                break;
        }
        return move;
    }


    
}
