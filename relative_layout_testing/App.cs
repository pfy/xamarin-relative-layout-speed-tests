using System;
using Xamarin.Forms;

namespace relative_layout_testing
{
	public class App
	{
		public static Page GetMainPage ()
		{	

			return new NavigationPage (
				new MainPage()
				);
		}

	}
}

