using carbase.Data.Interfaces;

namespace carbase.Data
{
	internal class DbRepository
	{
		#region singleton 
		private sealed class DbRepositoryCreator
		{
			internal static DbRepository Instance { get; private set; }

			static DbRepositoryCreator()
			{
				Instance = new DbRepository();
			}
		}
		#endregion

		internal static DbRepository Instance
		{
			get { return DbRepositoryCreator.Instance; }
		}

		#region Repositories

		private ICarRegistrationRepository _carRegistrationRepository;
		internal ICarRegistrationRepository CarRegistration
		{
			get
			{
				return _carRegistrationRepository ?? (_carRegistrationRepository = new CarRegistrationRepository());
			}
		}
		#endregion
	}
}