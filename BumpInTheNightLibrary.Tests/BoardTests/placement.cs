using NUnit.Framework;
using Rhino.Mocks;

namespace BumpInTheNightLibrary.Tests.BoardTests
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
            var message = new PlaceOnBoardMessage(3, 15, _piece);
            Should.ThrowException<InvalidPiecePlacementException>(() => _board.Place(message));
        }

        [Test]
        public void col_too_low()
        {
            var message = new PlaceOnBoardMessage(3, -1, _piece);
            Should.ThrowException<InvalidPiecePlacementException>(() => _board.Place(message));
        }

        [Test]
        public void row_too_high()
        {
            var message = new PlaceOnBoardMessage(15, 3, _piece);
            Should.ThrowException<InvalidPiecePlacementException>(() => _board.Place(message));
        }

        [Test]
        public void row_too_low()
        {
            var message = new PlaceOnBoardMessage(-1, 3, _piece);
            Should.ThrowException<InvalidPiecePlacementException>(() => _board.Place(message));
        }

        [Test]
        public void valid_placement()
        {
            var message = new PlaceOnBoardMessage(3, 3, _piece);
            _board.Place(message);
        }
    }
}