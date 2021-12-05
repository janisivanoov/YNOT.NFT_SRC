using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace NFTWEBSITE.Pages
{
    public class BestTokensModel : PageModel
    {
        private readonly ILogger<BestTokensModel> _logger;

        public BestTokensModel(ILogger<BestTokensModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}