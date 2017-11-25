namespace Vstsdemo.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System.Threading.Tasks;
    using Vsts.package;

    public class GetNameModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        private readonly IDemoPackage _demoPackage;

        public GetNameModel(IDemoPackage demoPackage)
        {
            _demoPackage = demoPackage;
        }

        //public IActionResult OnGet()
        //{
        //    Name = _demoPackage.GetNames();

        //    return Page();
        //}

        public async Task<IActionResult> OnGetAsync()
        {
            Name = await _demoPackage.GetNamesAsync();

            return Page();
        }
    }
}
