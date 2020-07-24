using CalulateMathLib;
using System;
using Xunit;

namespace TestCalulateMath
{
    public class UnitTestMath
    {
        [Theory]
        [InlineData(54, 24, 6)]
        [InlineData(42, 56, 14)]
        [InlineData(18, 84, 6)]
        [InlineData(461952, 116298, 18)]
        [InlineData(7966496, 314080416, 32)]
        [InlineData(24826148, 45296490, 526)]
        [InlineData(12, 0, 12)]
        [InlineData(0, 0, 0)]
        [InlineData(0, 9, 9)]
        [InlineData(13, 13, 13)]
        [InlineData(37, 600, 1)]
        [InlineData(20, 100, 20)]
        [InlineData(624129, 2061517, 18913)]
        [InlineData(120, 2, 2)]
        [InlineData(90, 3, 3)]
        [InlineData(1500, 5, 5)]
        [InlineData(0, 51, 51)]

        public void TestGCD(int a, int b, int expected)
        {
            var classGCD = new CalulateMath();
            var result = classGCD.CalulateGCD(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(21, 6, 42)]
        [InlineData(6, 21, 42)]
        [InlineData(12, 18, 36)]
        [InlineData(4, 6, 12)]
        [InlineData(15, 25, 75)]
        [InlineData(120, 2, 120)]
        [InlineData(54, 68, 1836)]
        [InlineData(15, 65, 195)]
        [InlineData(77, 66, 462)]
        [InlineData(23, 51, 1173)]
        [InlineData(17, 1223, 20791)]

        public void TestLCM(int a, int b, int expected)
        {
            var classGCD = new CalulateMath();
            var result = classGCD.CalulateLCM(a, b);
            Assert.Equal(expected, result);
        }
    }
}
