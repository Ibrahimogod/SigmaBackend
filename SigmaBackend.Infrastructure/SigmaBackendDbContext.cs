using Microsoft.EntityFrameworkCore;
using SigmaBackend.Domain.Models;

namespace SigmaBackend.Infrastructure;

public class SigmaBackendDbContext(DbContextOptions<SigmaBackendDbContext> options) : DbContext(options)
{
    public DbSet<Candidate> Candidates { get; set; }
}