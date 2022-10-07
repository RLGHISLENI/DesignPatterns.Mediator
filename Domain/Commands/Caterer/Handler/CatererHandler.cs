using DesignPatterns.Mediator.Domain.Commands.Caterer;
using MediatR;

namespace DesignPatterns.Mediator.Domain.Commands.Handlers.Caterer
{
    public class CatererHandler : IRequestHandler<CatererRequest, CatererResponse>
    {
        public Task<CatererResponse> Handle(
            CatererRequest request,
            CancellationToken cancellationToken)
        {
            var result = new CatererResponse
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Phone = request.Phone,
                Age = request.Age,
                Date = DateTime.Now
            };
            return Task.FromResult(result);
        }
    }
}
