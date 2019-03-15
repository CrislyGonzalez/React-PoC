using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoC.Models
{
    public class Meter
    {
		[Key]
		public int IdTrip { get; set; }

		public DateTime DateAndTimeTrip { get; set; }

		public string StateTrip { get; set; }

		public string OrigenRouteTrip { get; set; }

		public string DestinationRouteTrip { get; set; }

		public string MilesTrip { get; set; }
	}
}
