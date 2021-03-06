using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Save_Yoour_Apps.Work;

namespace Save_Yoour_Apps.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public int appsCount { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                appsCount = AppsWorker.AppsCount(HttpContext.User.Identity.Name);
            }
        }
    }
}