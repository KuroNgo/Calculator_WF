using CalLib;

namespace XUnitTestCalLib
{
    public class UnitTestOperations
    {
        public Operations op=new Operations();
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(7, -2, 5)]
        [InlineData(2, 2, 4)]
        [InlineData(1, 5, 6)]
        public void SummationTest(double a, double b, double expectedRes)
        {
            var res = op.Summation(a, b);
            Assert.True(expectedRes == res);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(7, -2, 9)]
        [InlineData(2, 2, 0)]
        [InlineData(10, 5.5, 4.5)]
        public void Subtraction(double a, double b, double expectedRes)
        {
            var res = op.Subtraction(a, b);
            Assert.True(expectedRes == res);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(7, -2, -14)]
        [InlineData(2, 2, 4)]
        [InlineData(10, 5.5, 55)]
        public void Multiplication(double a, double b, double expectedRes)
        {
            var res = op.Multiplication(a, b);
            Assert.True(expectedRes == res);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(7, 7, 1)]
        [InlineData(2, 2, 1)]
        [InlineData(5.5, 5.5, 1)]
        public void Division(double a, double b, double expectedRes)
        {
            var res = op.Division(a, b);
            Assert.True(expectedRes == res);
        }
    }
}