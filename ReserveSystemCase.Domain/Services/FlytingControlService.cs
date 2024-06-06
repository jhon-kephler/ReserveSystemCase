using AutoMapper;
using Newtonsoft.Json;
using ReserveSystemCase.Domain.Schema.Responses;
using ReserveSystemCase.Domain.Services.Interfaces;
using System.Net;

namespace ReserveSystemCase.Domain.Services
{
    public class FlytingControlService : IFlytingControlService
    {
        public readonly IMapper _mapper;

        public FlytingControlService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<List<FlytingInfosResponse>> GetFlytingControl()
        {
            var result = new List<FlytingInfosResponse>();
            var golAPI = await GolAPI();
            var latamAPI = await LatamAPI();

            golAPI.ForEach(x =>
            {
                result.Add(_mapper.Map<FlytingInfosResponse>(x));
            });

            latamAPI.ForEach(x =>
            {
                result.Add(_mapper.Map<FlytingInfosResponse>(x));
            });

            result.OrderBy(o => o.Tarifa);
            return result;
        }

        private async Task<List<APIGolResponse>> GolAPI()
        {
            var golRequest = WebRequest.CreateHttp("https://dev.reserve.com.br/airapi/gol/getavailability?origin=Rio%20de%20Janeiro&destination=S%C3%A3o%20Paulo&date=2024-06-20");
            golRequest.Method = "GET";
            var golResponse = await golRequest.GetResponseAsync();
            var streamDados = golResponse.GetResponseStream();
            StreamReader reader = new StreamReader(streamDados);
            object objResponse = reader.ReadToEnd();
            var result = JsonConvert.DeserializeObject<List<APIGolResponse>>(objResponse.ToString());

            return result;
        }
        private async Task<List<APILatamResponse>> LatamAPI()
        {
            var latamRequest = WebRequest.CreateHttp("https://dev.reserve.com.br/airapi/latam/flights?departureCity=Rio%20de%20Janeiro&arrivalCity=S%C3%A3o%20Paulo&departureDate=2024-06-20");
            latamRequest.Method = "GET";
            var latamResponse = await latamRequest.GetResponseAsync();
            var streamDados = latamResponse.GetResponseStream();
            StreamReader reader = new StreamReader(streamDados);
            object objResponse = reader.ReadToEnd();
            var result = JsonConvert.DeserializeObject<List<APILatamResponse>>(objResponse.ToString());

            return result;
        }
    }
}
