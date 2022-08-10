namespace LastDigitOfHugeNumber.Tests
{
	public class LastDigitOfHugeNumberTests
	{
		[Fact]
		public void TestEmpty()
		{
			Assert.Equal(1, Kata.LastDigit(Array.Empty<int>()));
			Assert.Equal(1, Kata.LastDigit(new int[] { 0, 0 }));
			Assert.Equal(0, Kata.LastDigit(new int[] { 0, 0, 0 }));
		}

		[Fact]
		public void MainTest()
		{
			Assert.Equal(1, Kata.LastDigit(new int[] { 1, 2 }));
			Assert.Equal(1, Kata.LastDigit(new int[] { 3, 4, 5 }));
			Assert.Equal(4, Kata.LastDigit(new int[] { 4, 3, 6 }));
			Assert.Equal(1, Kata.LastDigit(new int[] { 7, 6, 21 }));
			Assert.Equal(6, Kata.LastDigit(new int[] { 12, 30, 21 }));
			Assert.Equal(4, Kata.LastDigit(new int[] { 2, 2, 2, 0 }));
		}

		[Fact]
		public void TestBigInteger()
		{
			Assert.Equal(0, Kata.LastDigit(new int[] { 937640, 767456, 981242 }));
			Assert.Equal(6, Kata.LastDigit(new int[] { 123232, 694022, 140249 }));
			Assert.Equal(6, Kata.LastDigit(new int[] { 499942, 898102, 846073 }));
		}
	}
}