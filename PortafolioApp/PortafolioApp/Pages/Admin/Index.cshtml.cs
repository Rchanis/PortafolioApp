using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PortafolioApp.Pages.Admin;

[Authorize]
public class IndexModel : PageModel
{
    public void OnGet()
    {
        
    }
}