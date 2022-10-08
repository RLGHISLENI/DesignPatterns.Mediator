using DesignPatterns.Mediator.Domain.Commands.Caterer;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Mediator.Controllers
{
    [ApiController]
    [Route("v1/caterers")]
    public class CaterersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CaterersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("")]
        public Task<CatererResponse> Create(
           [FromBody] CatererRequest request)
        {
            return _mediator.Send(request);
        }
    }
}
