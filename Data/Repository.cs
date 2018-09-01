using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace carbase.Data
{
	internal abstract class Repository
	{
		protected IDbConnection DB { get; }

		internal Repository()
		{
			DB = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
		}
	}
}