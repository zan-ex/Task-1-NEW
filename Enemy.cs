using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Enemy : Character
{
    public Enemy(int X, int Y, int HP, int DAMAGE) : base(X, Y)
    {
        hp = HP;
        damage = DAMAGE;

    }

    public abstract override string ToString();

}
