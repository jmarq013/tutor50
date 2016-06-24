using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tutor50
{
	public partial class TutorEntry : ContentPage
	{
		private int updateID = 0;

		public TutorEntry(int id)
		{
			InitializeComponent();
			//var tutor = App.Database.GetTutor(id);
			//FirstName.Text = tutor.FirstName;
			//LastName.Text = tutor.LastName;
			//Email.Text = tutor.Email;
			//Phone.Text = tutor.Phone;
			//Rate.Text = tutor.Rate.ToString();
			//updateID = id;
		}

		public TutorEntry()
		{
			InitializeComponent();
		}

		public void OnPost(object o, EventArgs e)
		{
			Tutor tutor = new Tutor();
			tutor.FirstName = FirstName.Text;
			tutor.LastName = LastName.Text;
			tutor.Email = Email.Text;
			tutor.Phone = Phone.Text;
			tutor.Languages = Languages.Text;

			double tutorRate;
			if (Double.TryParse(Rate.Text, out tutorRate))
			{
				tutor.Rate = tutorRate;
			}
			else
			{
				DisplayAlert("Invalid Entry", "You must enter a numeric value", "OK");
				return;
			}

			tutor.ID = updateID;
			Clear();
			App.Database.SaveTutor(tutor);
			Navigation.PopModalAsync();
		}

		private void Clear()
		{
			FirstName.Text = LastName.Text = Email.Text = Phone.Text = Rate.Text = Languages.Text =String.Empty;
		}

		private void OnCancel(object o, EventArgs e)
		{
			Clear();
			Navigation.PopModalAsync();
		}

		//private void OnReview(object o, EventArgs e)
		//{
		//	Navigation.PushAsync(new TutorListPage());
		//}
	}
}

