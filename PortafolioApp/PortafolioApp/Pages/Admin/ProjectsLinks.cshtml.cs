using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PortafolioApp.Data;
using PortafolioApp.Models;


namespace PortafolioApp.Pages.Admin;

[Authorize]
public class ProjectLinksModel : PageModel
{
    private readonly AppDbContext _context;
    public ProjectLinksModel(AppDbContext context) => _context = context;

    public List<ProjectLink> ProjectLinks { get; set; }

    [BindProperty]
    public ProjectLink NewProjectLink { get; set; } = new();

    public async Task OnGetAsync() =>
        ProjectLinks = await _context.ProjectLinks.ToListAsync();

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        _context.ProjectLinks.Add(NewProjectLink);
        await _context.SaveChangesAsync();
        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostDeleteAsync(int id)
    {
        var link = await _context.ProjectLinks.FindAsync(id);
        if (link != null)
        {
            _context.ProjectLinks.Remove(link);
            await _context.SaveChangesAsync();
        }
        return RedirectToPage();
    }
}
