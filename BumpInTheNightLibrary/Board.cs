using System.Collections.Generic;

namespace BumpInTheNightLibrary
{
    public class Board
    {
        public Board(int rows, int columns)
        {
            create_squares(rows, columns);
        }

        Dictionary<int, Dictionary<int, BoardSquare>> _squares;

        void create_squares(int rows, int columns)
        {
            _squares = new Dictionary<int, Dictionary<int, BoardSquare>>();
            for (int r = 0; r < rows; r++)
            {
                _squares.Add(r, new Dictionary<int, BoardSquare>());
                for (int c = 0; c < columns; c++)
                    _squares[r].Add(c, new BoardSquare(r, c));
            }
        }

        public BoardSquare FindSquare(int x, int y)
        {
            return _squares[x][y];
        }

        //public void Place(PlaceOnPieceCommand message)
        //{
        //    if (CannotPlacePiece(message))
        //    {
        //        throw new InvalidPiecePlacementException();
        //    }
        //}

        //bool CannotPlacePiece(PlaceOnPieceCommand message)
        //{
        //    if (message.X < 0 || message.X > _rows)
        //        return true;
        //    if (message.Y < 0 || message.Y > _columns)
        //        return true;

        //    return false;
        //}
    }
}