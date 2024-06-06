using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReserveSystemCase.Domain.Schema.Request;
using ReserveSystemCase.Domain.Schema.Responses;

namespace ReserveSystemCase.Appication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlytingControlController : Controller
    {
        private readonly IMediator _mediator;

        public FlytingControlController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public Task<List<FlytingInfosResponse>> Get() =>
                _mediator.Send(new FlytingControlRequest());
    }
}
