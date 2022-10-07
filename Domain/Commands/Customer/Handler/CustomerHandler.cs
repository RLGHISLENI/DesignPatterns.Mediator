namespace DesignPatterns.Mediator.Domain.Commands.Customer.Handler
{
    public class CustomerHandler: ICustomerHandler
    {
        public CustomerResponse Handle(CustomerRequest request)
        {
            return new CustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                Date = DateTime.Now
            };
        }
    }
}
