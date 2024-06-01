using AutoMapper;
using SigmaBackend.Api.Candidates.Dtos;
using SigmaBackend.Domain.Models;

namespace SigmaBackend.Api.Candidates;

public class CandidateMappingProfile : Profile
{
    public CandidateMappingProfile()
    {
        CreateMap<CandidateDto, Candidate>();
    }
}