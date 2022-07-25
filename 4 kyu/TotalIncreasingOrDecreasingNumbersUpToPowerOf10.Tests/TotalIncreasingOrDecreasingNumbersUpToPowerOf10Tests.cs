namespace TotalIncreasingOrDecreasingNumbersUpToPowerOf10.Tests
{
	public class TotalIncreasingOrDecreasingNumbersUpToPowerOf10Tests
	{
		[Fact]
		public void Tests()
		{
			Assert.Equal(1, Kata.TotalIncDec(0));
			Assert.Equal(10, Kata.TotalIncDec(1));
			Assert.Equal(100, Kata.TotalIncDec(2));
			Assert.Equal(475, Kata.TotalIncDec(3));
			Assert.Equal(1675, Kata.TotalIncDec(4));
		}
	}
}