using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveSystemCase.Domain.Schema.Responses
{
    public class APILatamResponse
    {
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public string Airline { get; set; }
        public string FlightID { get; set; }
        public DateTime FlightStart { get; set; }
        public DateTime FlightEnd { get; set; }
        public decimal TotalFare { get; set; }
    }
}