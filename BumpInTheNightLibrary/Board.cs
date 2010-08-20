namespace BumpInTheNightLibrary
{
    public class Board
    {
        public Board(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
        }

        readonly int _columns;
        readonly int _rows;

        public void Place(PlaceOnBoardMessage message)
        {
            if (CannotPlacePiece(message))
            {
                throw new InvalidPiecePlacementException();
            }
        }

        bool CannotPlacePiece(PlaceOnBoardMessage message)
        {
            if (message.X < 0 || message.X > _rows)
                return true;
            if (message.Y < 0 || message.Y > _columns)
                return true;

            return false;
        }
    }
}