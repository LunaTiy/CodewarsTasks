using System;
using Xunit;
using RangeExtraction;

namespace RangeExtraction.Tests
{
	public class RangeExtractionTests
	{
		[Fact]
		public void ExtractTestPositiveNumbers()
		{
			Assert.Equal("1,2", Kata.Extract(new int[] { 1, 2 }));
			Assert.Equal("1-3", Kata.Extract(new int[] { 1, 2, 3 }));
			Assert.Equal("1-4", Kata.Extract(new int[] { 1, 2, 3, 4 }));
			Assert.Equal("1-4,6,7", Kata.Extract(new int[] { 1, 2, 3, 4, 6, 7}));
		}

		[Fact]
		public void ExtractTestNegativeNumbers()
		{
			Assert.Equal("-2,-1", Kata.Extract(new int[] { -2, -1 }));
			Assert.Equal("-4--1", Kata.Extract(new int[] { -4, -3, -2, -1 }));
		}

		[Fact]
		public void ExtractTestAllNumbers()
		{
			Assert.Equal("-6,-4--2,0-2,4", Kata.Extract(new int[] { -6, -4, -3, -2, 0, 1, 2, 4 }));
			Assert.Equal(
				"-6,-3-1,3-5,7-11,14,15,17-20",
				Kata.Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 })
			);
		}
	}
}
