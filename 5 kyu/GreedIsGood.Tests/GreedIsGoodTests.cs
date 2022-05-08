using System;
using Xunit;
using GreedIsGood;

namespace GreedIsGood.Tests
{
	public class GreedIsGoodTests
	{
		[Fact]
		public void ScoreTestShouldBeWorthLess()
		{
			Assert.Equal(0, Kata.Score(new int[] { 2, 3, 4, 6, 2 }));
		}

		[Fact]
		public static void ScoreTestShouldValueTriplets()
		{
			Assert.Equal(400, Kata.Score(new int[] { 4, 4, 4, 3, 3 }));
		}

		[Fact]
		public static void ScoreTestShouldValueMixedSets()
		{
			Assert.Equal(450, Kata.Score(new int[] { 2, 4, 4, 5, 4 }));
		}
	}
}
