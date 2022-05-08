using System;
using Xunit;
using MiddlePermutation;

namespace MiddlePermutation.Tests
{
	public class MiddlePermutationTests
	{
        [Fact]
        public void BasicTests()
        {
            Kata kata = new Kata();

            Assert.Equal("bac", kata.MiddlePermutation("abc"));
            Assert.Equal("bdca", kata.MiddlePermutation("abcd"));
            Assert.Equal("cbxda", kata.MiddlePermutation("abcdx"));
            Assert.Equal("cxgdba", kata.MiddlePermutation("abcdxg"));
            Assert.Equal("dczxgba", kata.MiddlePermutation("abcdxgz"));
        }
    }
}
