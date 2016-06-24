using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tutor50
{
	public partial class Register : ContentPage
	{
		public Register()
		{
			InitializeComponent();
		}

		public void RegisterClicked(object o, EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		public void OnCancel(object o, EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}

