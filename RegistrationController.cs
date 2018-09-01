using carbase.Data;
using carbase.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace carbase
{
	public class RegistrationController : ApiController
	{
		// GET api/<controller>
		[EnableCors(origins: "*", headers: "*", methods: "*")]
		public CarInformation Get([FromUri] string carNumber)
		{
			IEnumerable<RegistrationLine> lines = DbRepository.Instance.CarRegistration.Search(carNumber);
			if (!lines.Any()) return new CarInformation();

			var car = lines.FirstOrDefault();
			return new CarInformation
			{
				Description =
					new CarDescription(car.brand, car.model, car.make_year, car.color, car.kind, car.brand, car.purpose, car.fuel, car.capacity, car.own_weight, car.total_weight, car.n_reg_new),
				Registrations = lines.Select(x => new Registration { d_reg = x.d_reg, oper_name = x.oper_name })
			};
		}
	}
}