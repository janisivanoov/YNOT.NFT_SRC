using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace NFTWEBSITE.Pages
{
    public class ForumDevModel : PageModel
    {
        private readonly ILogger<ForumDevModel> _logger;

        public ForumDevModel(ILogger<ForumDevModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}