using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Permutations;

namespace Permutations.Tests
{
	public class PermutationsTests
	{
        [Fact]
        public void Example1()
        {
            Assert.Equal(new List<string> { "a" }, Kata.SinglePermutations("a").OrderBy(x => x).ToList());
        }

        [Fact]
        public void Example2()
        {
            Assert.Equal(new List<string> { "ab", "ba" }, Kata.SinglePermutations("ab").OrderBy(x => x).ToList());
        }

        [Fact]
        public void Example3()
        {
            Assert.Equal(new List<string> { "aabb", "abab", "abba", "baab", "baba", "bbaa" }, Kata.SinglePermutations("aabb").OrderBy(x => x).ToList());
        }
    }
}
