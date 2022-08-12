namespace HexToDecimal.Tests
{
	public class HexToDecimalTests
	{
		[Fact]
		public void Test1()
		{
			Assert.Equal(1, Kata.HexToDec("1"));
			Assert.Equal(10, Kata.HexToDec("a"));
			Assert.Equal(16, Kata.HexToDec("10"));
			Assert.Equal(255, Kata.HexToDec("FF"));
			Assert.Equal(-12, Kata.HexToDec("-C"));
		}
	}
}