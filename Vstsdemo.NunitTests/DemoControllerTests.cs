namespace Vstsdemo.tests
{
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using NUnit.Framework;
    using Vsts.package;

    [TestFixture]
    public class DemoControllerTests
    {
        private Mock<IDemoPackage> _demoPackage;

        [Test]
        public void Show_should_return_viewresult()
        {
            // Arrange
            _demoPackage = new Mock<IDemoPackage>();
            var controller = new DemoController(_demoPackage.Object);

            // Act
            var result = controller.Show();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public void DisplayNames_should_return_viewresult()
        {
            // Arrange
            _demoPackage = new Mock<IDemoPackage>();
            var controller = new DemoController(_demoPackage.Object);

            // Act
            var result = controller.DisplayNames();

            // Assert
            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}
