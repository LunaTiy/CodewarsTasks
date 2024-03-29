﻿using System;
using Xunit;
using DescendingOrder;

namespace DescendingOrder.Tests
{
	public class DescendingOrderTests
	{
		[Fact]
		public void DescendingOrderTest01()
		{
			Assert.Equal(43210, Kata.DescendingOrder(23140));
		}

		[Fact]
		public void DescendingOrderTest02()
		{
			Assert.Equal(886553311, Kata.DescendingOrder(518158633));
		}

		[Fact]
		public void DescendingOrderTest03()
		{
			Assert.Equal(0, Kata.DescendingOrder(-100));
		}
	}
}
