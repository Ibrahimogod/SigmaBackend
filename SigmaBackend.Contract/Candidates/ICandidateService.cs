using SigmaBackend.Domain.Models;

namespace SigmaBackend.Contract.Candidates;

public interface ICandidateService
{
    Task<Candidate> AddCandidateAsync(Candidate candidate, CancellationToken cancellationToken);
}