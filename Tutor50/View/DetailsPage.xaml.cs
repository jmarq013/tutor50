using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tutor50
{
	public partial class DetailsPage : ContentPage
	{
		public DetailsPage(Tutor tutor)
		{
			string _phone = String.Format("{0:(###) ###-####}", double.Parse(tutor.Phone));

			BindingContext = tutor;
			InitializeComponent();

			Phone.Text = _phone;
		}
	}
}

