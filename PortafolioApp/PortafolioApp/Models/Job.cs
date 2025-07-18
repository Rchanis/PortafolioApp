using System.Runtime.InteropServices.JavaScript;

namespace PortafolioApp.Models;

public class Job
{
    public int Id { get; set; }

    public string Company { get; set; } = "";

    public string Title { get; set; } = "";

    public string Description { get; set; } = "";

    public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.Today);

    public DateOnly? EndDate { get; set; }  = DateOnly.FromDateTime(DateTime.Today);

    public string Location { get; set; } = "";  
   
}