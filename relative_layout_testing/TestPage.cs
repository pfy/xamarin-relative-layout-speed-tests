using System;
using Xamarin.Forms;

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
				BoxView backgroundLine = new BoxView (){BackgroundColor = Color.Gray };
				relative.Children.Add (
					backgroundLine,
					Constraint.Constant (0),
					Constraint.Constant(imageSize / 2 -1),
					Constraint.RelativeToParent (p => p.Width), 
					Constraint.Constant (2)
				);


				for (int j = 0; j < images_count; j++) {
					int index = j;
					var box = new BoxView (){ BackgroundColor = Color.Blue, WidthRequest = imageSize, HeightRequest = imageSize };
					relative.Children.Add (
						box,
						Constraint.RelativeToParent(
							p =>  (index * ((p.Width-(images_count)* imageSize) / (images_count- 1) + imageSize))
						),
						Constraint.Constant(0));
					Label l = new Label (){ Text = "" + index, XAlign=TextAlignment.Center,
						WidthRequest = 53};
					relative.Children.Add (l, Constraint.RelativeToView (box, (p,v) => v.X),
						Constraint.Constant(imageSize+5)
					);
				}
				stacker.Children.Add (relative);
			}

			Content = scroll;
		}
	}
}

