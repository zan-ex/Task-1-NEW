using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GameEngine
{
    private Map map;
    private char hero = 'H', empty = '.',
        goblin = 'G', obstacle = 'X';

    public GameEngine(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies)
    {
        map = new Map(minWidth, maxWidth, minHeight, maxHeight, numEnemies);

    }

    public Map Map
    {
        get { return map; }
        set { map = value; }
    }

    public bool MovePlayer(Character.Movement direction)
    {
        return true;

    }
    public override string ToString()
    {
        return null;
    }
}
