using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace Vstsdemo.tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Home_should_return_viewresult()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Show();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }
    }
}
