using System;
using Xunit;
using System.Collections.Generic;
using IsNumberPrime;

namespace IsNumberPrime.Tests
{
	public class IsNumberPrimeTests
	{
		[Fact]
		public void IsPrimeTest()
		{
			List<int> trueCases = new List<int>() { 2, 3, 5, 7, 11, 13 };
			List<int> falseCases = new List<int>() { -1, 0, 1, 4, 6, 8 };

			foreach (int trueCase in trueCases)
				Assert.True(Kata.IsPrime(trueCase));

			foreach (int falseCase in falseCases)
				Assert.False(Kata.IsPrime(falseCase));
		}
	}
}
