using static TicTacToeAvalonia.MainWindow;

namespace TicTacToeTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Board board = new Board();

            Assert.IsTrue(board.boardStates.Count == 9, "The board should have 9 states.");
            Assert.IsTrue(board.boardStates[board.boardGrid[0]] == PieceType.EmptySpace, "The first cell should be empty.");


        }
    }
}
