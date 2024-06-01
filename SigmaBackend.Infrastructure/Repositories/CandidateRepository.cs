using SigmaBackend.Domain.Models;

namespace SigmaBackend.Infrastructure.Repositories;

public class CandidateRepository(SigmaBackendDbContext context) : Repository<Candidate, Guid>(context);