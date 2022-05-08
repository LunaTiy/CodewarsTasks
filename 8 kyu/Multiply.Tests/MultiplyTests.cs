using System;
using Xunit;
using Multiply;

namespace Multiply.Tests
{
	public class MultiplyTests
	{
		[Fact]
		public static void Test01()
		{
			Assert.Equal(4, Kata.Multiply(2, 2));
			Assert.Equal(0, Kata.Multiply(0, 100));
			Assert.Equal(100, Kata.Multiply(50, 2));
			Assert.Equal(-100, Kata.Multiply(25, -4));
		}
	}
}
