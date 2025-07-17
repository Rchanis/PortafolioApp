namespace PortafolioApp.Models;

public class Certifications
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Issuer { get; set; } = "";
    public DateTime DateObtained { get; set; }
    public string? CertificateUrl { get; set; } 
    public string? CredentialId { get; set; }
}