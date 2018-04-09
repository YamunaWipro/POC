using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace POC.View
{
	public class UserDetailSingleView : ContentPage
	{
		public UserDetailSingleView (DetailsModel monkey)
		{
            
            AbsoluteLayout peakLayout = new AbsoluteLayout { HeightRequest = 250, BackgroundColor =  Color.FromRgb(8, 141, 165) };

            //Set Detail View Title
            var title = new Label
            {
                Text = monkey.Name.ToString(),
                FontSize = 42,
                FontFamily = "Verdana",
                FontAttributes=FontAttributes.Bold,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                
            };
            var image = new Frame()
            {
                CornerRadius = 10,
                IsClippedToBounds = true,
                MinimumHeightRequest = 200,
                MinimumWidthRequest = 200,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Padding = 0,
                Content =new Image()
                {

                    Source = monkey.Image,
                    Aspect = Aspect.AspectFill,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    HeightRequest = 300,
                    WidthRequest = 300
                }
            };
            var description = new Frame()
            {
                Padding = new Thickness(10, 5),
                HasShadow = false,
                BackgroundColor = Color.Transparent,
                Content = new Label()
                {
                    FontSize = 20,
                    FontAttributes=FontAttributes.Italic,
                    TextColor = Color.FromHex("#ddd"),
                    Text = monkey.Details
                }
            };
            
            peakLayout.Children.Add(title);
            peakLayout.Children.Add(image);
            
           var stack = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromRgb(8, 141, 165),
                Children = {title,image,description}
            };
            Content = new ScrollView { Content = stack };
        }
	}
}