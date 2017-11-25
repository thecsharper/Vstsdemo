namespace Vstsdemo.tests
{
    using Microsoft.AspNetCore.Mvc;
    using Xunit;
    using Vsts.package;
    using Moq;

    public class DemoControllerTests
    {
        private Mock<IDemoPackage> _demoPackage;

        [Fact]
        public void Show_should_return_viewresult()
        {
            // Arrange
            _demoPackage = new Mock<IDemoPackage>();
            var controller = new DemoController(_demoPackage.Object);

            // Act
            var result = controller.Show();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void DisplayNames_should_return_viewresult()
        {
            // Arrange
            _demoPackage = new Mock<IDemoPackage>();
            var controller = new DemoController(_demoPackage.Object);

            // Act
            var result = controller.DisplayNames();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }
    }
}
