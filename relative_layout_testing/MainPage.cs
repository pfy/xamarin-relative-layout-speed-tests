using System;
using Xamarin.Forms;

namespace relative_layout_testing
{
	public class MainPage: ContentPage
	{
		public MainPage ()
		{
			var stack = new StackLayout ();
			var button = new Button () {
				Text = "click for minimal test"
			};
			button.Clicked += (object sender, EventArgs e) => {
				Navigation.PushAsync(new TestPage());
			};
			stack.Children.Add (button);

			button = new Button () {
				Text = "click for how it should look test"
			};
			button.Clicked += (object sender, EventArgs e) => {
				Navigation.PushAsync(new HowItShouldLook());
			};
			stack.Children.Add (button);

			Content = stack;
		}
	}
}

