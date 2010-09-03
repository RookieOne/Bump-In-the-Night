using BumpInTheNightLibrary.Commands;
using NUnit.Framework;

namespace BumpInTheNightLibrary.Tests.CommandTests
{
    [TestFixture]
    public class add_wall
    {
        [SetUp]
        public void setup()
        {
            _board = new Board(5, 5);
        }

        Board _board;

        [Test]
        public void place_south_wall()
        {
            new AddWallCommand(1, 3, BoardSquare.SOUTH).Execute(_board);
            _board.FindSquare(1,3).HasWallOn(BoardSquare.SOUTH).ShouldBe(true);
        }

        [Test]
        public void place_west_wall()
        {
            new AddWallCommand(1, 3, BoardSquare.WEST).Execute(_board);
            _board.FindSquare(1, 3).HasWallOn(BoardSquare.WEST).ShouldBe(true);
        }

        [Test]
        public void place_north_wall()
        {
            new AddWallCommand(1, 3, BoardSquare.NORTH).Execute(_board);
            _board.FindSquare(1, 3).HasWallOn(BoardSquare.NORTH).ShouldBe(true);
        }

        [Test]
        public void place_east_wall()
        {
            new AddWallCommand(1, 3, BoardSquare.EAST).Execute(_board);
            _board.FindSquare(1, 3).HasWallOn(BoardSquare.EAST).ShouldBe(true);
        }
    }
}