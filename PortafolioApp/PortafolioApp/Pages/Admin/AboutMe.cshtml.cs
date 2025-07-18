using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace PortafolioApp.Pages.Admin;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PortafolioApp.Data;
using PortafolioApp.Models;

public class AboutMeModel : PageModel
{
    private readonly AppDbContext _context;

    public AboutMeModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public AboutMe AboutMe { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
        AboutMe = await _context.AboutMeEntries.FirstOrDefaultAsync();

        if (AboutMe == null)
        {
            AboutMe = new AboutMe { Content = "" };
            _context.AboutMeEntries.Add(AboutMe);
            await _context.SaveChangesAsync();
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var existing = await _context.AboutMeEntries.FirstOrDefaultAsync();
        if (existing != null)
        {
            existing.Content = AboutMe.Content;
        }
        else
        {
            _context.AboutMeEntries.Add(AboutMe);
        }

        await _context.SaveChangesAsync();
        return RedirectToPage();
    }
}
