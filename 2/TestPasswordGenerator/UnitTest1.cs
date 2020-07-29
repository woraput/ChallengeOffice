using PasswordGenerator;
using System;
using Xunit;

namespace TestPasswordGenerator
{
    public class UnitTestChallenge2
    {
        private static PassGenerator classTest = new PassGenerator();

        [Theory]
        [InlineData("iFSkTQJl", false)]
        [InlineData("IDvs6i8s", false)]
        [InlineData("WR3ltGmo", false)]
        [InlineData("oTO7OhKa", false)]
        [InlineData("oT070hKa", true)]
        [InlineData("oT070TKa", false)]
        [InlineData("oTO7OhTa", false)]
        [InlineData("jr47iWHr", false)]
        [InlineData("CMXDUqnZ", false)]
        [InlineData("VB2edRt9", true)]
        [InlineData("TiisTGRE", false)]
        [InlineData("iWref3Ro", false)]
        [InlineData("asONBgsg", false)]
        [InlineData("iWref3Ro", false)]
        [InlineData("4SdSajjl", false)]
        [InlineData("NU5HzAgB", false)]
        [InlineData("0aH18BxT", true)]
        [InlineData("YJ15jlpH", true)]
        [InlineData("l0fbIJ7J", false)]
        [InlineData("kLo0TfJu", false)]
        [InlineData("rIFcaumr", false)]
        [InlineData("DoJKxsHG", false)]
        [InlineData("151545AB", false)]
        [InlineData("151545AB", false)]
        [InlineData("15154cAB", true)]

        public void TestPassGenerator1(string pass, bool expected)
        {
            var result = classTest.PassGen14Test(pass);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("J7E2HHG2", false)]
        [InlineData("NPCWUJWA", false)]
        [InlineData("47HM0PYQ", false)]
        [InlineData("oT070hKa", false)]
        [InlineData("637ALVBK", false)]
        [InlineData("oTO7OhTa", false)]
        [InlineData("3WH3D201", true)]
        [InlineData("5364857F", false)]
        [InlineData("YTZNX7TL", false)]
        [InlineData("5C32Z32P", true)]
        [InlineData("13Z27495", false)]
        [InlineData("1234567A", false)]
        public void TestPassGenerator2(string pass, bool expected)
        {
            var result = classTest.PassGen24Test(pass);
            Assert.Equal(expected, result);
        }
    }
}
