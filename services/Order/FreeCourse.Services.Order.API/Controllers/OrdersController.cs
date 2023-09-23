using FreeCourse.Services.Order.Application.Commands;
using FreeCourse.Services.Order.Application.Queries;
using FreeCourse.Shared.Services;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreeCourse.Services.Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly ISharedIdentityService _sharedIdentityService;

        public OrdersController(ISharedIdentityService sharedIdentityService, IMediator mediator)
        {
            _sharedIdentityService = sharedIdentityService;
            _mediator = mediator;
        }



        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var response = _mediator.Send(new GetOrdersByUserIdQuery() { UserId = _sharedIdentityService.GetUserId });

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrder(CreateOrderCommand createOrderCommand)
        {

            var response = _mediator.Send(createOrderCommand);
            return Ok(response);
        }

    }
}
