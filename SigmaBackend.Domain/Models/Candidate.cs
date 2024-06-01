namespace SigmaBackend.Domain.Models;

public class Candidate : Entity<Guid>
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    public string Email { get; set; }
    
    public TimeSpan? PreferredCallTime { get; set; }

    public string? LinkedinUrl { get; set; }
    
    public string? GithubUrl { get; set; }
    
    public string Comment { get; set; }
}