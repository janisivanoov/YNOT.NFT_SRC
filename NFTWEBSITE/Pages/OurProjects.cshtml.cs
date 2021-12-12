using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace NFTWEBSITE.Pages
{
    public class OurProjectsModel : PageModel
    {
        private readonly ILogger<OurProjectsModel> _logger;

        public OurProjectsModel(ILogger<OurProjectsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}