using System;
using BumpInTheNightLibrary.Extensions;

namespace BumpInTheNightLibrary.Commands
{
    public class CommandException : Exception
    {
        public CommandException(IBoardCommand command, Exception innerException)
            : base("Exception while executing command {0}".FormatWith(command), innerException)
        {
        }
    }
}