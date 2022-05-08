using System;
using Xunit;
using HumanReadableTime;

namespace HumanReadableTime.Tests
{
	public class HumanReadableTimeTests
	{
		[Fact]
		public void TestGetReadableTime()
		{
			Assert.Equal("00:00:00", TimeFormat.GetReadableTime(0));
			Assert.Equal("00:00:05", TimeFormat.GetReadableTime(5));
			Assert.Equal("00:01:00", TimeFormat.GetReadableTime(60));
			Assert.Equal("23:59:59", TimeFormat.GetReadableTime(86399));
			Assert.Equal("99:59:59", TimeFormat.GetReadableTime(359999));
		}

		[Fact]
		public void TestGetReadableTimeNotNull()
		{
			Assert.NotNull(TimeFormat.GetReadableTime(300));
			Assert.NotNull(TimeFormat.GetReadableTime(60000));
			Assert.NotNull(TimeFormat.GetReadableTime(90000));
		}

		[Fact]
		public void TestGetReadableTimeIsNull()
		{
			Assert.Null(TimeFormat.GetReadableTime(-1));
			Assert.Null(TimeFormat.GetReadableTime(360000));
			Assert.Null(TimeFormat.GetReadableTime(-1000));
		}
	}
}
