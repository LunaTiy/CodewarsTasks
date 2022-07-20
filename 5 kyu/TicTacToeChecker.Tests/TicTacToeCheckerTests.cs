namespace TicTacToeChecker.Tests
{
	public class TicTacToeCheckerTests
	{
		[Fact]
		public void TestNull()
		{
			int[,] board = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
			Assert.Equal(-1, Kata.IsSolved(board));
		}

		[Fact]
		public void TestDraw()
		{
			int[,] board = new int[,] { { 1, 1, 2 }, { 2, 2, 1 }, { 1, 2, 1 } };
			Assert.Equal(0, Kata.IsSolved(board));
		}

		[Fact]
		public void TestHorizontal()
		{
			int[,] board1 = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
			Assert.Equal(1, Kata.IsSolved(board1));

			int[,] board2 = new int[,] { { 1, 0, 1 }, { 0, 2, 2 }, { 2, 2, 2 } };
			Assert.Equal(2, Kata.IsSolved(board2));
		}

		[Fact]
		public void TestVertical()
		{
			int[,] board1 = new int[,] { { 1, 2, 1 }, { 0, 1, 1 }, { 0, 2, 1 } };
			Assert.Equal(1, Kata.IsSolved(board1));

			int[,] board2 = new int[,] { { 1, 2, 1 }, { 0, 2, 2 }, { 0, 2, 0 } };
			Assert.Equal(2, Kata.IsSolved(board2));
		}

		[Fact]
		public void TestDiagonals()
		{
			int[,] board1 = new int[,] { { 1, 2, 1 }, { 0, 1, 1 }, { 1, 2, 0 } };
			Assert.Equal(1, Kata.IsSolved(board1));

			int[,] board2 = new int[,] { { 0, 2, 2 }, { 1, 2, 1 }, { 2, 1, 1 } };
			Assert.Equal(2, Kata.IsSolved(board2));
		}
	}
}