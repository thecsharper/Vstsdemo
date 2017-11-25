using Microsoft.AspNetCore.Mvc;
using Vsts.package;


namespace Vstsdemo
{
    public class DemoController : Controller
    {
        private readonly IDemoPackage _demoPackage;

        public DemoController(IDemoPackage demoPackage)
        {
            _demoPackage = demoPackage;
        }

        public IActionResult Show()
        {
            return View();
        }

        public IActionResult DisplayNames()
        {
            var model = new Models.NameModel
            {
                Name = _demoPackage.GetNames()
            };

            return View(model);
        }
    }
}
