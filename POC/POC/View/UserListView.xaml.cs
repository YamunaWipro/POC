using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using POC;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POC.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserListView : ContentPage
	{
		public UserListView ()
		{
			InitializeComponent ();
            BindingContext = new UserListViewModel();
        }
        private async void Cell_Tapped(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            string location = l.Text;
            //HERE I NEED HELP TO TAKE THE VALUE OF CELL !!!!! HOW 
            if (Device.RuntimePlatform == Device.iOS)
            {
                //https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                Device.OpenUri(new Uri(string.Format("http://maps.apple.com/?q={0}", WebUtility.UrlEncode(location))));
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // opens the Maps app directly
                Device.OpenUri(new Uri(string.Format("geo:0,0?q={0}", WebUtility.UrlEncode(location))));

            }
            else if (Device.RuntimePlatform == Device.UWP || Device.RuntimePlatform == Device.WinPhone)
            {
                Device.OpenUri(new Uri(string.Format("bingmaps:?where={0}", Uri.EscapeDataString(location))));
            }
        }
        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => App.Current.MainPage.Navigation.PushAsync(new UserDetailsSingleView((DetailsModel)e.Item));
    }
}