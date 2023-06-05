using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAirport.Classes
{
    public class OperatorRegistration
    {
        public int Id { get; set; }

        public DateTime DateSchule { get; set; }
        public string Aviacompany { get; set; }
        public int NumberFlight { get; set; }
        public string Direction { get; set; }
        public string Status { get; set; }
        public string TypeFlights { get; set; }
        public DateTime ActualyTime { get; set; }

    }
}
