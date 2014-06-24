using System;
using Xamarin.Forms;

namespace relative_layout_testing
{
	public class MainPage: ContentPage
	{
		public MainPage ()
		{
			var button = new Button () {
				Text = "click to test speed"
			};
			button.Clicked += (object sender, EventArgs e) => {
				Navigation.PushAsync(new TestPage());
			};
			Content = button;
		}
	}
}

