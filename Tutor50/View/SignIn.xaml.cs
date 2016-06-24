using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tutor50
{
	public partial class SignIn : ContentPage
	{
		public SignIn()
		{
			InitializeComponent();
		}

		public void SignInClicked(object o, EventArgs e)
		{
			Navigation.PushAsync(new TutorListPage());
		}

		public void OnCancel(object o, EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}

