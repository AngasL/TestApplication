using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitProject
{
    [TestClass]
    public class UnitTest1
    {
        private Mock<IJump> mockJump;
        private User user;

        [TestInitialize]
        public void Init()
        {
            mockJump = new Mock<IJump>();
            user = new User(mockJump.Object);
        }

        [TestMethod]
        public void UserActionMethod_ShouldCallJumpMethod()
        {
            // Arrange
            var returnValueFormJumpInterface = "123";
            mockJump.Setup(m => m.Action(It.Is<string>(a => a == "123"))).Returns(returnValueFormJumpInterface);

            // Action
            var actualResult = user.GetActionName();

            //Assert
            Assert.AreEqual(actualResult, returnValueFormJumpInterface);
        }
    }
}
