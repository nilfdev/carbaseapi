using carbase.Models;
using System.Collections.Generic;

namespace carbase.Data.Interfaces
{
	internal interface ICarRegistrationRepository
	{
		IEnumerable<RegistrationLine> Search(string carNumber);
	}
}