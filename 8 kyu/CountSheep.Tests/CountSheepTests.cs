using CountSheep;

namespace TestProject1
{
	public class CountSheepTests
	{
		[Fact]
		public void Test1()
		{
			Assert.Equal("", Kata.CountSheep(0));
			Assert.Equal("1 sheep...", Kata.CountSheep(1));
			Assert.Equal("1 sheep...2 sheep...", Kata.CountSheep(2));
			Assert.Equal("1 sheep...2 sheep...3 sheep...", Kata.CountSheep(3));
		}
	}
}