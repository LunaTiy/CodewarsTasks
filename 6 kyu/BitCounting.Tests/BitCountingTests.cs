using System;
using Xunit;

namespace BitCounting.Tests
{
	public class BitCountingTests
	{
		[Fact]
		public void CountBitsTest01()
		{
			Assert.Equal(0, Kata.CountBits(0));
			Assert.Equal(1, Kata.CountBits(4));
			Assert.Equal(3, Kata.CountBits(7));
			Assert.Equal(2, Kata.CountBits(9));
			Assert.Equal(2, Kata.CountBits(10));
		}
	}
}
