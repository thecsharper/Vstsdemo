using Microsoft.AspNetCore.Mvc;
using Vsts.package;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vstsdemo
{
    public class HomeController : Controller
    {
        private readonly IDemoPackage _demoPackage;

        public HomeController(IDemoPackage demoPackage)
        {
            _demoPackage = demoPackage;
        }

        public IActionResult Show()
        {
            return View();
        }

        public IActionResult GetName()
        {
            return View(_demoPackage);
        }
    }
}
