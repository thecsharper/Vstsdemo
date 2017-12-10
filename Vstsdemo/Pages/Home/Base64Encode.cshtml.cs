namespace Vstsdemo.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System;
    using System.Collections.Generic;
    using Vsts.package;

    public class Base64EncodeModel : PageModel
    {
        [BindProperty]
        public string EncodedString { get; set; }

        public string DecodedString { get; set; }

        private readonly IDemoPackage _demoPackage;

        public Base64EncodeModel(IDemoPackage demoPackage)
        {
            _demoPackage = demoPackage;
        }

        public IActionResult OnGetAsync()
        {
            EncodedString = Guid.NewGuid().ToString();

            return Page();
        }

        public JsonResult OnGetList()
        {
            var lstString = new List<string>
            {
            "Sam",
            "Fred",
            "Jack"
            };

            return new JsonResult(lstString);
        }

    }
}
