using System;
using Xunit;
using PlayingWithDigits;
using System.Collections.Generic;

namespace PlayingWithDigits.Tests
{
	public class PlayingWithDigitsTests
	{
		[Fact]
		public void DigitPowTest01()
		{
			// Arrange
			int n = 89;
			int p = 1;

			// Act
			long result = DigPow.DigitPow(n, p);

			// Assert
			Assert.Equal(1, result);
		}

		[Fact]
		public void DigitPowTest02()
		{
			// Arrange
			int n = 92;
			int p = 1;

			// Act
			long result = DigPow.DigitPow(n, p);

			// Assert
			Assert.Equal(-1, result);
		}

		[Fact]
		public void DigitPowTest03()
		{
			// Arrange
			int n = 46288;
			int p = 3;

			// Act
			long result = DigPow.DigitPow(n, p);

			// Assert
			Assert.Equal(51, result);
		}

		[Fact]
		public void SplitNumberIntoDigitsTest01()
		{
			int number = 4031;
			List<int> correctDigits = new List<int>() { 4, 0, 3, 1};

			Assert.Equal(correctDigits, DigPow.SplitNumberIntoDigits(number));
		}

		[Fact]
		public void SplitNumberIntoDigitsTest02()
		{
			int number = 908101;
			List<int> correctDigits = new List<int>() { 9, 0, 8, 1, 0, 1};

			Assert.Equal(correctDigits, DigPow.SplitNumberIntoDigits(number));
		}

		[Fact]
		public void SumOfDigitsInPowTest01()
		{
			List<int> digits = new List<int>() { 4, 0, 3, 1 };
			int pow = 1;

			Assert.Equal(32, DigPow.SumOfDigitsInPow(digits, pow));
		}

		[Fact]
		public void SumOfDigitsInPowTest02()
		{
			List<int> digits = new List<int>() { 9, 1, 4, 3 };
			int pow = 2;

			Assert.Equal(581, DigPow.SumOfDigitsInPow(digits, pow));
		}

		[Fact]
		public void SearchMultuplierTest01()
		{
			int number = 89;
			int sum = 89;

			Assert.Equal(1, DigPow.SearchMultiplier(number, sum));
		}

		[Fact]
		public void SearchMultuplierTest02()
		{
			int number = 91;
			int sum = 82;

			Assert.Equal(-1, DigPow.SearchMultiplier(number, sum));
		}

		[Fact]
		public void SearchMultuplierTest03()
		{
			int number = 46288;
			int sum = 2360688;

			Assert.Equal(51, DigPow.SearchMultiplier(number, sum));
		}
	}
}
