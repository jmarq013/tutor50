using Xamarin.Forms;

namespace Tutor50
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new EntryPage());
		}

		static TutorDatabase database;

		public static TutorDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new TutorDatabase();
				}
				return database;
			}
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

