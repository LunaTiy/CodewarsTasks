using System;
using Xunit;
using FindTheParityOutlier;

namespace FindTheParityOutlier.Tests
{
	public class FindTheParityOutlierTests
	{
		[Fact]
		public void FindTheParityOutlierTest01()
		{
			// Arrange
			int[] array = new int[] { 0, 400, 200, 3, 202 };

			// Act
			int result = Kata.Find(array);

			// Assert
			Assert.Equal(3, result);
		}

		[Fact]
		public void FindTheParityOutlierTest02()
		{
			// Arrange
			int[] array = new int[] { -101, 3, 205, 47, -1001, 10500, 45 };

			// Act
			int result = Kata.Find(array);

			// Assert
			Assert.Equal(10500, result);
		}

		[Fact]
		public void FindTheParityOutlierTest03()
		{
			// Arrange
			int[] array = new int[] { 100, 200, 33, 47 };

			// Act
			int result = Kata.Find(array);

			// Assert
			Assert.Equal(-1, result);
		}
	}
}
