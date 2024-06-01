using SigmaBackend.Contract.Candidates;
using SigmaBackend.Domain.Models;
using SigmaBackend.Infrastructure.Repositories;

namespace SigmaBackend.Application.Candidates;

public class CandidateService(IRepository<Candidate> candidateRepository) : ICandidateService
{
    public Task<Candidate> AddCandidateAsync(Candidate candidate, CancellationToken cancellationToken)
    {
        return candidateRepository.InsertAsync(candidate, cancellationToken);
    }
}