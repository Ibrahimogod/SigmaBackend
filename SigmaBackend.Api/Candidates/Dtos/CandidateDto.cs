using System.ComponentModel.DataAnnotations;

namespace SigmaBackend.Api.Candidates.Dtos;

public class CandidateDto
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Phone]
    public string? PhoneNumber { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [Timestamp]
    public TimeSpan? PreferredCallTime { get; set; }
    [Url]
    public string? LinkedinUrl { get; set; }
    [Url]
    public string? GithubUrl { get; set; }
    [Required]
    public string Comment { get; set; }
}