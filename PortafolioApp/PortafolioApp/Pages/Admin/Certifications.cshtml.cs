using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PortafolioApp.Data;
using PortafolioApp.Models;


namespace PortafolioApp.Pages.Admin;

[Authorize]
public class CertificationsModel : PageModel
{
    private readonly AppDbContext _context;
    public CertificationsModel(AppDbContext context) => _context = context;

    public List<Certification> Certifications { get; set; }

    [BindProperty]
    public Certification NewCertification { get; set; } = new();

    public async Task OnGetAsync() =>
        Certifications = await _context.Certifications.ToListAsync();

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        _context.Certifications.Add(NewCertification);
        await _context.SaveChangesAsync();
        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostDeleteAsync(int id)
    {
        var cert = await _context.Certifications.FindAsync(id);
        if (cert != null)
        {
            _context.Certifications.Remove(cert);
            await _context.SaveChangesAsync();
        }
        return RedirectToPage();
    }
}
