using System;
using Xunit;
using Rot13;

namespace Rot13.Tests
{
	public class Rot13Tests
	{
		[Fact]
		public void Rot13EncryptTestLowCase()
		{
			Assert.Equal("grfg", Kata.Rot13Encrypt("test"));
		}

		[Fact]
		public void Rot13EncryptTestHighCase()
		{
			Assert.Equal("GRFG", Kata.Rot13Encrypt("TEST"));
		}

		[Fact]
		public void Rot13EncryptTestPasclaCase()
		{
			Assert.Equal("Grfg", Kata.Rot13Encrypt("Test"));
		}

		[Fact]
		public void Rot13EncryptTestWithOtherCharacters()
		{
			Assert.Equal("g1rfg!", Kata.Rot13Encrypt("t1est!"));
		}

		[Fact]
		public void Rot13EncryptTestIsNull()
		{
			Assert.Null(Kata.Rot13Encrypt(""));
			Assert.Null(Kata.Rot13Encrypt(null));
		}

		[Fact]
		public void Rot13EncryptTestAllCharacter()
		{
			Assert.Equal("nopqrstuvwxyzabcdefghijklm", Kata.Rot13Encrypt("abcdefghijklmnopqrstuvwxyz"));
		}
	}
}
