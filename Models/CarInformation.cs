using carbase.Models;
using System.Collections.Generic;

namespace carbase.Models
{
	public class CarInformation
	{
		public CarDescription Description { get; set; }
		public IEnumerable<Registration> Registrations { get; set; }
	}
}