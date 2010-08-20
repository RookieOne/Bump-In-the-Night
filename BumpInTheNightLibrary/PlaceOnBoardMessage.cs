namespace BumpInTheNightLibrary
{
    public class PlaceOnBoardMessage
    {
        public PlaceOnBoardMessage(int x, int y, IBoardPiece piece)
        {
            X = x;
            Y = y;
            Piece = piece;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public IBoardPiece Piece { get; private set; }
    }
}