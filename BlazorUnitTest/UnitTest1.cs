using System;
using Xunit;
using BlazorTest;

namespace BlazorUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestDivide()
        {
            var common = new Commom();
            Assert.Equal(1, common.Divide(1,1));
        }

        [Fact]
        public void TestDivide0()
        {
            var common = new Commom();
            Assert.Throws<Exception>(() => { common.Divide(1, 0); });
        }
    }
}
