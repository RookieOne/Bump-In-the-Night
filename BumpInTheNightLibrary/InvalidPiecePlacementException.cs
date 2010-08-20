using System;

namespace BumpInTheNightLibrary
{
    public class InvalidPiecePlacementException : Exception
    {
        public InvalidPiecePlacementException()
            : base("Invalid piece placement")
        {
        }
    }
}