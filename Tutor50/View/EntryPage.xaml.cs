using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tutor50
{
	public partial class EntryPage : ContentPage
	{
		public EntryPage()
		{
			InitializeComponent();
		}

		public void OnSignIn(object o, EventArgs e)
		{
			Navigation.PushModalAsync(new SignIn());
		}

		public void OnRegister(object o, EventArgs e)
		{
			Navigation.PushModalAsync(new Register());
		}

		public void Guest(object o, EventArgs e)
		{
			Navigation.PushAsync(new TutorListPage());
		}
	}


}

