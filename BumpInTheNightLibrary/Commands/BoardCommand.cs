using System;

namespace BumpInTheNightLibrary.Commands
{
    public abstract class BoardCommand : IBoardCommand
    {
        public void Execute(Board board)
        {
            try
            {
                ExecuteCommand(board);
            }
            catch (Exception e)
            {
                throw new CommandException(this, e);
            }
        }

        protected abstract void ExecuteCommand(Board board);
    }
}