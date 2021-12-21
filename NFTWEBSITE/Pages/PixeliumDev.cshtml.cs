using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace NFTWEBSITE.Pages
{
    public class PixeliumDevModel : PageModel
    {
        private readonly ILogger<PixeliumDevModel> _logger;

        public PixeliumDevModel(ILogger<PixeliumDevModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}