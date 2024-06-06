using MediatR;
using ReserveSystemCase.Domain.Schema.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveSystemCase.Domain.Schema.Request
{
    public class FlytingControlRequest : IRequest<List<FlytingInfosResponse>>
    {
    }
}
