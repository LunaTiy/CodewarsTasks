using System;
using Xunit;
using BinomialExpansion;

namespace BinomialExpansion.Tests
{
	public class BinomialExpansionTests
	{
		[Fact]
        public void Test01Positive()
        {
            Assert.Equal("1", Kata.Expand("(x+1)^0"));
            Assert.Equal("x+1", Kata.Expand("(x+1)^1"));
            Assert.Equal("x^2+2x+1", Kata.Expand("(x+1)^2"));
        }

        [Fact]
        public void Test01Negative()
        {
            Assert.Equal("1", Kata.Expand("(x-1)^0"));
            Assert.Equal("x-1", Kata.Expand("(x-1)^1"));
            Assert.Equal("x^2-2x+1", Kata.Expand("(x-1)^2"));
        }

        [Fact]
        public void Test02Positive()
        {
            Assert.Equal("625m^4+1500m^3+1350m^2+540m+81", Kata.Expand("(5m+3)^4"));
            Assert.Equal("8x^3-36x^2+54x-27", Kata.Expand("(2x-3)^3"));
            Assert.Equal("1", Kata.Expand("(7x-7)^0"));
        }

        [Fact]
        public void Test02Negative()
        {
            Assert.Equal("625m^4-1500m^3+1350m^2-540m+81", Kata.Expand("(-5m+3)^4"));
            Assert.Equal("-8k^3-36k^2-54k-27", Kata.Expand("(-2k-3)^3"));
            Assert.Equal("1", Kata.Expand("(-7x-7)^0"));
        }

        [Fact]
        public void RandomTest()
		{
            
            Assert.Equal("-w^5-130w^4-6760w^3-175760w^2-2284880w-11881376", Kata.Expand("(-w-26)^5"));
        }
    }
}
