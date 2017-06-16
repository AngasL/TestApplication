using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using FluentAssertions;

namespace MoqTest
{
    public class BaseClass
    {
        public int GetPublicData(string input)
        {
            return this.GetInternalData(input);
        }

        protected virtual int GetInternalData(string input)
        {
            return 123;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mockInstance = new Mock<BaseClass>();
            mockInstance.Protected().Setup<int>("GetInternalData", ItExpr.IsAny<string>()).Returns(234);
            var actualResult = mockInstance.Object.GetPublicData("321");

            actualResult.Should().Be(234);
        }
    }
}
