using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SigmaBackend.Api.Candidates.Dtos;
using SigmaBackend.Contract.Candidates;
using SigmaBackend.Domain.Models;

namespace SigmaBackend.Api.Candidates.Controllers;

[Route("api/[controller]")]
public class CandidatesController(ICandidateService candidateService, IMapper mapper) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody]CandidateDto candidateDto, CancellationToken cancellationToken)
    {
        var candidate = mapper.Map<Candidate>(candidateDto);
        return Ok(await candidateService.AddCandidateAsync(candidate, cancellationToken));
    }
}