using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PortafolioApp.Data;
using PortafolioApp.Models;

namespace PortafolioApp.Pages.Admin;

[Authorize]
public class JobsModel : PageModel
{
    private readonly AppDbContext _context;
    public JobsModel(AppDbContext context) => _context = context;

    public List<Job> Jobs { get; set; }

    [BindProperty]
    public Job NewJob { get; set; } = new();

    public async Task OnGetAsync() =>
        Jobs = await _context.Jobs.ToListAsync();

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        _context.Jobs.Add(NewJob);
        await _context.SaveChangesAsync();
        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostDeleteAsync(int id)
    {
        var job = await _context.Jobs.FindAsync(id);
        if (job != null)
        {
            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();
        }
        return RedirectToPage();
    }
}