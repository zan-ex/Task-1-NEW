using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Character : Tile
{
  
    protected int HP;
    protected int MAXHP;
    protected int DAMAGE;

    protected Tile[] ArrCharVision;

    public int hp
    {
        get { return HP; }
        set { HP = value; }
    }

    public int maxHp
    {
        get { return MAXHP; }
        set { MAXHP = value; }
    }

    public int damage
    {
        get { return DAMAGE; }
        set { DAMAGE = value; }
    }

    public Tile[] ArrVision
    {
        get { return ArrCharVision; }
        set { ArrCharVision = value; }
    }

    public Character(int X, int Y) : base(X, Y)
    {

    }

    public enum Movement
    {
        None,
        Up,
        Down,
        Left,
        Right
    }

    public virtual void Attack(Character target)
    {
        target.hp -= damage;
    }

    public bool IsDead()
    {
        if (hp <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public int range = 1;

    private int DistanceTo(Character target)
    {
        return Math.Abs(X - target.X) + Math.Abs(Y - target.Y);
    }
    public virtual bool CheckRange(Character target)
    {
        if (DistanceTo(target) <= range)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Move(Movement move)
    {
        switch (move)
        {
            case Movement.None:
                break;

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
    }

    public abstract Movement returnMove(Movement move = 0);

    public abstract override string ToString();

}
