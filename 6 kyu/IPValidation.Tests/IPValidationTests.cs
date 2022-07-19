namespace IPValidation.Tests
{
	public class IPValidationTests
	{
		[Fact]
		public void TestCases()
		{
			Assert.True(Kata.IsValidIP("0.0.0.0"));
            Assert.True(Kata.IsValidIP("12.255.56.1"));
            Assert.True(Kata.IsValidIP("137.255.156.100"));

            Assert.False(Kata.IsValidIP(""));
            Assert.False(Kata.IsValidIP("abc.def.ghi.jkl"));
            Assert.False(Kata.IsValidIP("123.456.789.0"));
            Assert.False(Kata.IsValidIP("12.34.56"));
            Assert.False(Kata.IsValidIP("12.34.56.00"));
            Assert.False(Kata.IsValidIP("12.34.56.7.8"));
            Assert.False(Kata.IsValidIP("12.34.256.78"));
            Assert.False(Kata.IsValidIP("1234.34.56"));
            Assert.False(Kata.IsValidIP("pr12.34.56.78"));
            Assert.False(Kata.IsValidIP("12.34.56.78sf"));
            Assert.False(Kata.IsValidIP("12.34.56 .1"));
            Assert.False(Kata.IsValidIP("12.34.56.-1"));
            Assert.False(Kata.IsValidIP("123.045.067.089"));
		}
	}
}