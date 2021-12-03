using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace NFTWEBSITE.Pages
{
    public class MetaverseDevModel : PageModel
    {
        private readonly ILogger<MetaverseDevModel> _logger;

        public MetaverseDevModel(ILogger<MetaverseDevModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}