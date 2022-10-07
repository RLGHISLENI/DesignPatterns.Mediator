using DesignPatterns.Mediator.Domain.Commands.Caterer;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Mediator.Controllers
{
    [ApiController]
    [Route("v1/caterers")]
    public class CaterersController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Task<CatererResponse> Create(
           [FromServices] IMediator mediator,
           [FromBody] CatererRequest request)
        {
            return mediator.Send(request);
        }
    }
}
