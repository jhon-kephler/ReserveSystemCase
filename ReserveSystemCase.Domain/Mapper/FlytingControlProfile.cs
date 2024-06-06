using AutoMapper;
using ReserveSystemCase.Domain.Schema.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveSystemCase.Domain.Mapper
{
    public class FlytingControlProfile : Profile
    {
        public FlytingControlProfile()
        {
            CreateMap<APIGolResponse, FlytingInfosResponse>()
                .ForMember(dest => dest.Voo, src => src.MapFrom(x => x.FlightNumber))
                .ForMember(dest => dest.Destino, src => src.MapFrom(x => x.DestinationAirport))
                .ForMember(dest => dest.Tarifa, src => src.MapFrom(x => x.FarePrice))
                .ForMember(dest => dest.Origem, src => src.MapFrom(x => x.OriginAirport))
                .ForMember(dest => dest.Partida, src => src.MapFrom(x => x.DepartureDate))
                .ForMember(dest => dest.Chegada, src => src.MapFrom(x => x.ArrivalDate))
                .ForMember(dest => dest.Companhia, src => src.MapFrom(x => x.Carrier));

            CreateMap<APILatamResponse, FlytingInfosResponse>()
                .ForMember(dest => dest.Voo, src => src.MapFrom(x => x.FlightID))
                .ForMember(dest => dest.Destino, src => src.MapFrom(x => x.ArrivalAirport))
                .ForMember(dest => dest.Tarifa, src => src.MapFrom(x => x.TotalFare))
                .ForMember(dest => dest.Origem, src => src.MapFrom(x => x.DepartureAirport))
                .ForMember(dest => dest.Partida, src => src.MapFrom(x => x.FlightStart))
                .ForMember(dest => dest.Chegada, src => src.MapFrom(x => x.FlightEnd))
                .ForMember(dest => dest.Companhia, src => src.MapFrom(x => x.Airline));
        }
    }
}
