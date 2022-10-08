using DesignPatterns.Mediator.Domain.Commands.Customer;
using DesignPatterns.Mediator.Domain.Commands.Customer.Handler;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Mediator.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerHandler _handler;

        public CustomerController(ICustomerHandler customerHandler)
        {
            _handler = customerHandler;
        }

        [HttpPost]
        [Route("")]
        public CustomerResponse Create(
           [FromBody] CustomerRequest request)
        {
            return _handler.Handle(request);
        }
    }
}
