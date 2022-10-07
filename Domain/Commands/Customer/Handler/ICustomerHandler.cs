namespace DesignPatterns.Mediator.Domain.Commands.Customer.Handler
{
    public interface ICustomerHandler
    {
        CustomerResponse Handle(CustomerRequest request);
    }
}
