using DesignPatterns.Mediator.Domain.Commands.Customer;
using DesignPatterns.Mediator.Domain.Commands.Customer.Handler;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Mediator.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public CustomerResponse Create(
           [FromServices] ICustomerHandler customerHandler,
           [FromBody] CustomerRequest request)
        {
            return customerHandler.Handle(request);
        }
    }
}
