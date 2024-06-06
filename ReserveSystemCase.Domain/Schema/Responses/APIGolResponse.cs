using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveSystemCase.Domain.Schema.Responses
{
    public class APIGolResponse
    {
        public string FlightNumber { get; set; }
        public string Carrier { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }   
        public string OriginAirport { get; set; }
        public string DestinationAirport { get; set; }
        public decimal FarePrice { get; set; }


    }
}