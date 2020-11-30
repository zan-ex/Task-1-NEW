using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Map
{

    private Tile[,] GameMap;
    private Hero Hero;
    private Goblin Goblin;
    private Enemy[] ArrEnemy;
    private int Width = 10;
    private int Height = 10;
    private Random rnd = new Random();

    public Tile[,] gameMap
    {
        get { return GameMap; }
        set { GameMap = value; }
    }
    public Hero hero
    {
        get { return Hero; }
        set { Hero = value; }
    }
    public Goblin goblin
    {
        get { return Goblin; }
        set { Goblin = value; }
    }
    public Enemy[] arrEnemy
    {
        get { return ArrEnemy; }
        set { ArrEnemy = value; }
    }
    public int width
    {
        get { return Width; }
        set { Width = value; }
    }
    public int height
    {
        get { return Height; }
        set { Height = value; }
    }

    public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies) // creates the full map loadout for the program
    {
        arrEnemy = new Enemy[numEnemies];
        width = rnd.Next(minWidth, maxWidth +1);
        height = rnd.Next(minHeight, maxHeight+1);
        gameMap = new Tile[width, height];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                gameMap[i, j] = new Empty(i, j);
            }
        }

        hero = (Hero)Create(Tile.TileType.Hero);
        gameMap[hero.x, hero.y] = hero;

        for (int i = 0; i < numEnemies; i++)
        {
            arrEnemy[i] = (Enemy)Create(Tile.TileType.Enemy);
            gameMap[arrEnemy[i].x, arrEnemy[i].y] = arrEnemy[i];

            arrEnemy[i] = new Goblin(
                X, Y, 10, 1, 'G');
        }

    }
    private Tile Create(Tile.TileType type) //creates the tiles used to populate map tiles with characters
    {
        int x = rnd.Next(0, Width);
        int y = rnd.Next(0, Height);

        Tile NewTile = null;

        switch (type)
        {
            case Tile.TileType.Enemy:
                NewTile = new Goblin(X, Y, 10, 1, 'G');
                break;
        }
        return NewTile;
    }

}
