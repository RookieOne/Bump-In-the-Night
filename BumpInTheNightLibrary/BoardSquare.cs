using System.Collections.Generic;

namespace BumpInTheNightLibrary
{
    public class BoardSquare
    {
        public BoardSquare(int x, int y)
        {
            _x = x;
            _y = y;
            _walls = new Dictionary<int, Wall>();
        }

        public const int EAST = 0;
        public const int NORTH = 0;
        public const int SOUTH = 0;
        public const int WEST = 0;
        readonly Dictionary<int, Wall> _walls;

        readonly int _x;
        readonly int _y;
        IBoardPiece _piece;

        public void Place(IBoardPiece piece)
        {
            _piece = piece;
        }

        public void AddWall(int direction)
        {
            _walls.Add(direction, new Wall());
        }

        public bool HasWallOn(int direction)
        {
            return _walls.ContainsKey(direction);
        }
    }
}