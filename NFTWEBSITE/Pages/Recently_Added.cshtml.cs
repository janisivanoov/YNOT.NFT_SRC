using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace NFTWEBSITE.Pages
{
    public class Recently_AddedModel : PageModel
    {
        private readonly ILogger<Recently_AddedModel> _logger;

        public Recently_AddedModel(ILogger<Recently_AddedModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}