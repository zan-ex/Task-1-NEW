using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Tile
{
    protected int X;
    protected int Y;

    public int x
    {
        get { return X; }
        set { X = value; }
    }

    public int y
    {
        get { return Y; }
        set { Y = value; }
    }

    public enum TileType
    {
        Hero,
        Enemy,
        Weapon,
        Gold
    }


    public Tile(int X, int Y)
    {

        x = X;
        y = Y;

    }

}