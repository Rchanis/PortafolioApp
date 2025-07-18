namespace PortafolioApp.Models;

public class Certification
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Issuer { get; set; } = "";
    public DateOnly DateObtained { get; set; } = DateOnly.FromDateTime(DateTime.Today);
    public string? CertificateUrl { get; set; } 
    public string? CredentialId { get; set; }
}