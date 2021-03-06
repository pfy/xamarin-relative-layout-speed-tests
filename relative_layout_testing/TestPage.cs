﻿using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace relative_layout_testing
{
	public class TestPage: ContentPage
	{
		protected const int imageSize = 45;
		protected const int images_count = 4;

		public TestPage ()
		{
			var scroll = new ScrollView ();

			var stacker = new StackLayout () {
			};
			scroll.Content = stacker;


			for(int i = 0; i < 20; i++){
				var relative = new RelativeLayout ();

				for (int j = 0; j < images_count; j++) {
					int index = j;
					var box = new BoxView (){ BackgroundColor = Color.Blue, WidthRequest = imageSize, HeightRequest = imageSize };
					relative.Children.Add (
						box,
						Constraint.RelativeToParent( p => (index * ((p.Width-(images_count)* imageSize) / (images_count- 1) + imageSize))
						),
						Constraint.Constant(0));
				}
				stacker.Children.Add (relative);
			}
			Content = scroll;
		}
			
	}
}

