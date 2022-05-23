﻿using Ardalis.ApiEndpoints;
using Treble_backend.Core.ProjectAggregate;
using Treble_backend.Core.ProjectAggregate.Specifications;
using Treble_backend.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Treble_backend.Web.Endpoints.ProjectEndpoints;

public class GetById : EndpointBaseAsync
    .WithRequest<GetProjectByIdRequest>
    .WithActionResult<GetProjectByIdResponse>
{
  private readonly IRepository<Project> _repository;

  public GetById(IRepository<Project> repository)
  {
    _repository = repository;
  }

  [HttpGet(GetProjectByIdRequest.Route)]
  [SwaggerOperation(
      Summary = "Gets a single Project",
      Description = "Gets a single Project by Id",
      OperationId = "Projects.GetById",
      Tags = new[] { "ProjectEndpoints" })
  ]
  public override async Task<ActionResult<GetProjectByIdResponse>> HandleAsync([FromRoute] GetProjectByIdRequest request,
      CancellationToken cancellationToken)
  {
    var spec = new ProjectByIdWithItemsSpec(request.ProjectId);
    var entity = await _repository.GetBySpecAsync(spec); // TODO: pass cancellation token
    if (entity == null) return NotFound();

    var response = new GetProjectByIdResponse
    (
        id: entity.Id,
        name: entity.Name,
        items: entity.Items.Select(item => new ToDoItemRecord(item.Id, item.Title, item.Description, item.IsDone)).ToList()
    );
    return Ok(response);
  }
}