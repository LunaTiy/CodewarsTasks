namespace Collatz.Tests
{
	public class CollatzTests
	{
		[Fact]
		public void BasicTests()
		{
			Assert.Equal("3->10->5->16->8->4->2->1", Kata.Collatz(3));
		}
	}
}