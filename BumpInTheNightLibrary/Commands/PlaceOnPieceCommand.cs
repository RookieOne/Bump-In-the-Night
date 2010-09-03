namespace BumpInTheNightLibrary.Commands
{
    public class PlaceOnPieceCommand : BoardCommand
    {
        public PlaceOnPieceCommand(int x, int y, IBoardPiece piece)
        {
            _x = x;
            _y = y;
            _piece = piece;
        }

        readonly IBoardPiece _piece;
        readonly int _x;
        readonly int _y;

        protected override void ExecuteCommand(Board board)
        {
            board.FindSquare(_x, _y).Place(_piece);
        }
    }
}