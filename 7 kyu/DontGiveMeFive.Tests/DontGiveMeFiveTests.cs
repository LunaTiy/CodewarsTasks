using System;
using Xunit;
using DontGiveMeFive;

namespace DontGiveMeFive.Tests
{
	public class DontGiveMeFiveTests
	{
		[Fact]
		public void DontGiveMeFiveTest01()
		{
			Assert.Equal(8, Kata.DontGiveMeFive(1, 9));
			Assert.Equal(12, Kata.DontGiveMeFive(4, 17));
			Assert.Equal(44, Kata.DontGiveMeFive(1, 50));
		}
	}
}
