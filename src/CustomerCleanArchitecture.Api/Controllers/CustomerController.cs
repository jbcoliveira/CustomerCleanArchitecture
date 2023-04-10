using CustomerCleanArchitecture.Application.Customers.CreateCustomer;
using CustomerCleanArchitecture.Application.Customers.GetAllCustomers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerCleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var response = await _mediator.Send(new GetAllCustomersRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(CreateCustomerRequest payload)
        {
            var newlyCreateItemId = await _mediator.Send(payload);
            return Ok(newlyCreateItemId);
        }
    }
}
