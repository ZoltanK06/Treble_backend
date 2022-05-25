using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Treble_backend.Core.Services;
using Treble_backend.Web.ApiModels;

namespace Treble_backend.Web.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PenaltyController : ControllerBase
{
  private readonly IPenaltyService _penaltyService;
  private readonly IMapper _mapper;
  public PenaltyController(IPenaltyService penaltyService, IMapper mapper)
  {
    _penaltyService = penaltyService;
    _mapper = mapper;
  }

  [HttpGet]
  public async Task<IActionResult> GetPenalties()
  {
    try
    {
      var penalties = await _penaltyService.GetPenalties();
      List<PenaltyDTO> penaltiesDto = _mapper.Map<List<PenaltyDTO>>(penalties);
      return Ok(penaltiesDto);
    }
    catch (Exception ex)
    {
      return BadRequest(ex.Message);
    }
  }
}
