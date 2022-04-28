using System;
using Xunit;
using FirstNonRepeatingCharacter;

namespace FirstNonRepeatingCharacter.Tests
{
	public class FirstNonRepeatingCharacterTests
	{
		[Fact]
		public void FirstNonRepeatingLetterTest()
		{
			Assert.Equal("a", Kata.FirstNonRepeatingLetter("a"));
			Assert.Equal("t", Kata.FirstNonRepeatingLetter("stress"));
			Assert.Equal("e", Kata.FirstNonRepeatingLetter("moonmen"));
		}

		[Fact]
		public void FirstNonRepeatingLetterTestCaseLetter()
		{
			Assert.Equal("A", Kata.FirstNonRepeatingLetter("A"));
			Assert.Equal("T", Kata.FirstNonRepeatingLetter("sTreSS"));
			Assert.Equal("e", Kata.FirstNonRepeatingLetter("moonmen"));
		}

		[Fact]
		public void FirstNonRepeatingLetterTestIsNull()
		{
			Assert.Equal("", Kata.FirstNonRepeatingLetter("aABb"));
			Assert.Equal("", Kata.FirstNonRepeatingLetter(""));
			Assert.Equal("", Kata.FirstNonRepeatingLetter(null));
		}
	}
}
