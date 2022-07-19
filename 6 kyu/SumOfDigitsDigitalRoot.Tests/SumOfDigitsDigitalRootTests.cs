namespace SumOfDigitsDigitalRoot.Tests
{
	public class SumOfDigitsDigitalRootTests
	{
		[Fact]
		public void Tests()
		{
			Assert.Equal(7, Kata.DigitalRoot(16));
			Assert.Equal(6, Kata.DigitalRoot(456));
		}
	}
}