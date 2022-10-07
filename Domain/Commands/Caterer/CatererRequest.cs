using MediatR;

namespace DesignPatterns.Mediator.Domain.Commands.Caterer
{
    public class CatererRequest : IRequest<CatererResponse>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }
}
