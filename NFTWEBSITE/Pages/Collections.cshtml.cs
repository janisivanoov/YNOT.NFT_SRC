using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace NFTWEBSITE.Pages
{
    public class CollectionsModel : PageModel
    {
        private readonly ILogger<CollectionsModel> _logger;

        public CollectionsModel(ILogger<CollectionsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}