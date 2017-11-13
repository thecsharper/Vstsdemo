namespace Vstsdemo.tests
{
    using Microsoft.AspNetCore.Mvc;
    using Xunit;
    using Vsts.package;
    using Moq;

    public class HomeControllerTests
    {
        private Mock<IDemoPackage> _demoPackage;

        [Fact]
        public void Home_should_return_viewresult()
        {
            // Arrange

            _demoPackage = new Mock<IDemoPackage>();
            var controller = new HomeController(_demoPackage.Object);

            // Act
            var result = controller.Show();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }
    }
}
