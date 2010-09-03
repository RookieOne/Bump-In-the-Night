using BumpInTheNightLibrary.Commands;
using NUnit.Framework;
using Rhino.Mocks;

namespace BumpInTheNightLibrary.Tests.CommandTests
{
    [TestFixture]
    public class placement
    {
        [SetUp]
        public void setup()
        {
            _board = new Board(10, 10);
            _piece = MockRepository.GenerateStub<IBoardPiece>();
        }

        Board _board;
        IBoardPiece _piece;

        [Test]
        public void col_too_high()
        {
            var command = new PlaceOnPieceCommand(3, 15, _piece);
            Should.ThrowException<CommandException>(() => command.Execute(_board));
        }

        [Test]
        public void col_too_low()
        {
            var command = new PlaceOnPieceCommand(3, -1, _piece);
            Should.ThrowException<CommandException>(() => command.Execute(_board));
        }

        [Test]
        public void row_too_high()
        {
            var command = new PlaceOnPieceCommand(15, 3, _piece);
            Should.ThrowException<CommandException>(() => command.Execute(_board));
        }

        [Test]
        public void row_too_low()
        {
            var command = new PlaceOnPieceCommand(-1, 3, _piece);
            Should.ThrowException<CommandException>(() => command.Execute(_board));
        }

        [Test]
        public void valid_placement()
        {
            var command = new PlaceOnPieceCommand(3, 3, _piece);
            command.Execute(_board);
        }
    }
}