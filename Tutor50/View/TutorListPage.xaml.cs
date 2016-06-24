using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tutor50
{
	public partial class TutorListPage : ContentPage
	{
		//TutorListPageViewModel vm;

		public TutorListPage()
		{
			//vm = new TutorListPageViewModel();
			//BindingContext = vm;
			InitializeComponent();

			this.ToolbarItems.Add(new ToolbarItem
			{
				Text = "Post Ad",
				Order = ToolbarItemOrder.Primary,
				Command = new Command(() => Navigation.PushModalAsync(new TutorEntry()))
			});
		}

		public void OnItemTapped(object o, ItemTappedEventArgs e)
		{
			var item = e.Item as Tutor;
			Navigation.PushAsync(new DetailsPage(item));
		}

		//public void OnClick(object o, EventArgs e)
		//{
		//	Navigation.PushModalAsync(new TutorEntry());
		//}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (App.Database.GetTutors() != null)
			{
				TutorList.ItemsSource = App.Database.GetTutors();
			}
		}
	}
}

