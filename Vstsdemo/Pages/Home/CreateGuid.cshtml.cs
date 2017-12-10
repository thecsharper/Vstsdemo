namespace Vstsdemo.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System;
    using Vsts.package;

    public class CreateGuidModel : PageModel
    {
        [BindProperty]
        public Guid Identifier { get; set; }

        private readonly IDemoPackage _demoPackage;

        public CreateGuidModel(IDemoPackage demoPackage)
        {
            _demoPackage = demoPackage;
        }
        
        public IActionResult OnGetAsync()
        {
            Identifier = Guid.NewGuid();

            return Page();
        }
    }
}
