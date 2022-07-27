namespace SquareIntoSquaresProtectTrees.Tests
{
	public class SquareIntoSquaresProtectTreesTests
	{
		[Fact]
		public void Test1()
		{
			Assert.Equal("1 2 4 10", Kata.Decompose(11));
			Assert.Equal("1 2 3 7 9", Kata.Decompose(12));
			Assert.Equal("1 2 14 100", Kata.Decompose(101));
			Assert.Equal("2 5 8 34 624", Kata.Decompose(625));
		}
	}
}