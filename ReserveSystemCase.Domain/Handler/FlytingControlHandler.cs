using MediatR;
using ReserveSystemCase.Domain.Schema.Request;
using ReserveSystemCase.Domain.Schema.Responses;
using ReserveSystemCase.Domain.Services.Interfaces;

namespace ReserveSystemCase.Domain.Handler
{
    public class FlytingControlHandler : IRequestHandler<FlytingControlRequest, List<FlytingInfosResponse>>
    {
        public readonly IFlytingControlService _flytingControlService;

        public FlytingControlHandler(IFlytingControlService flytingControlService)
        {
            _flytingControlService = flytingControlService;
        }

        public async Task<List<FlytingInfosResponse>> Handle(FlytingControlRequest request, CancellationToken cancellationToken) =>
                                    await _flytingControlService.GetFlytingControl();
    }
}
