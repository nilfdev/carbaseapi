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
		private const string SpecializedTypeString = "СПЕЦІАЛІЗОВАНИЙ";
		private const string SpecialTypeString = "СПЕЦІАЛЬНИЙ";
		private const string GeneralTypeString = "ЗАГАЛЬНИЙ";

		private IDictionary<string, Purposes> _carPurposes = new Dictionary<string, Purposes>()
		{
			{ GeneralTypeString,  Purposes.General },
			{ SpecialTypeString,  Purposes.Special },
			{ SpecializedTypeString,  Purposes.Specialized }
		};

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
				Registrations = lines.Select(x => new Registration { d_reg = x.d_reg, oper_name = x.oper_name, dep = x.dep }),
				Type = (int) (_carPurposes.ContainsKey(car.purpose) ? _carPurposes[car.purpose] : Purposes.Undefined)
			};
		}
	}
}