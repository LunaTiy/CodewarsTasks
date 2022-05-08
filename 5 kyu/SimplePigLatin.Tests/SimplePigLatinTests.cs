using System;
using Xunit;
using SimplePigLatin;

namespace SimplePigLatin.Tests
{
	public class SimplePigLatinTests
	{
		[Fact]
		public void PigItTest01()
		{
			Assert.Equal("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));
		}

		[Fact]
		public void PigItTest02()
		{
			Assert.Equal("hisTay siay ymay tringsay", Kata.PigIt("This is my string"));
		}

		[Fact]
		public void PigItTestWithPunctuations()
		{
			Assert.Equal("yMay, amenay, siay, aniilDay!", Kata.PigIt("My, name, is, Daniil!"));
		}
	}
}
