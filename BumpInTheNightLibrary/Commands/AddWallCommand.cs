namespace BumpInTheNightLibrary.Commands
{
    public class AddWallCommand : BoardCommand
    {
        public AddWallCommand(int x, int y, int direction)
        {
            _x = x;
            _y = y;
            _direction = direction;
        }

        readonly int _direction;

        readonly int _x;
        readonly int _y;

        protected override void ExecuteCommand(Board board)
        {
            board.FindSquare(_x, _y).AddWall(_direction);
        }
    }
}