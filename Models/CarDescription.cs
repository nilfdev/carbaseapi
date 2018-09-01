namespace carbase.Models
{
	public class CarDescription
	{
		public CarDescription(string brand, string model, string make_year, string color, string kind,
			string body,
			string purpose,
			string fuel,
			string capacity,
			string own_weight,
			string total_weight,
			string n_reg_new)
		{
			this.brand = brand;
			this.model = model;
			this.make_year = make_year;
			this.color = color;
			this.kind = kind;
			this.body = body;
			this.purpose = purpose;
			this.fuel = fuel;
			this.capacity = capacity;
			this.own_weight = own_weight;
			this.total_weight = total_weight;
			this.n_reg_new = n_reg_new;
		}

		public string brand { get; set; }
		public string model { get; set; }
		public string make_year { get; set; }
		public string color { get; set; }
		public string kind { get; set; }
		public string body { get; set; }
		public string purpose { get; set; }
		public string fuel { get; set; }
		public string capacity { get; set; }
		public string own_weight { get; set; }
		public string total_weight { get; set; }
		public string n_reg_new { get; set; }
	}
}