using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace NFTWEBSITE.Pages
{
    public class MetaverseModel : PageModel
    {
        private readonly ILogger<MetaverseModel> _logger;

        public MetaverseModel(ILogger<MetaverseModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}