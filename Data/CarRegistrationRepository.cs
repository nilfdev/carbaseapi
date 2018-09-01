using System.Collections.Generic;
using carbase.Data.Interfaces;
using carbase.Models;
using Dapper;

namespace carbase.Data
{
	internal class CarRegistrationRepository : Repository, ICarRegistrationRepository
	{
		public IEnumerable<RegistrationLine> Search(string carNumber)
		{
			return DB.Query<RegistrationLine>(@"
				SELECT
					oper_code,oper_name,d_reg,dep,brand,model,make_year,color,kind,body,purpose,fuel,capacity,own_weight,total_weight,n_reg_new
				FROM dbo.tz_opendata_z01012018_po01082018
				WHERE n_reg_new = @carNumber", new { carNumber });
		}
	}
}