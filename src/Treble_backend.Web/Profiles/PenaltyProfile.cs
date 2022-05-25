using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Treble_backend.Core.ProjectAggregate;
using Treble_backend.Web.ApiModels;

namespace Treble_backend.Web.Profiles;

public class PenaltyProfile : Profile
{
  public PenaltyProfile()
  {
    this.CreateMap<Penalty, PenaltyDTO>();
    this.CreateMap<PenaltyDTO, Penalty>();
  }
}
