using Xamarin.Forms;
using POC.View;
using POC.ViewModels;
using System;
using Xamarin.Forms.Maps;
using System.Net;
using Microsoft.Identity.Client;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace POC
{
    public partial class MainPage : ContentPage
    {
        public INavigation _navigation;
        AuthenticationResult ar;
        public MainPage()
        {
            InitializeComponent();
            LoginViewModel viewmodel = new LoginViewModel();
            BindingContext = viewmodel;


            viewmodel._navigation = this.Navigation;
        }
        /*    public async Task RefreshUserDataAsync(string token)
         {
             //get data from API
             HttpClient client = new HttpClient();
             HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, "https://graph.microsoft.com/v1.0/me");
             message.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", token);
             HttpResponseMessage response = await client.SendAsync(message);
             string responseString = await response.Content.ReadAsStringAsync();
             if (response.IsSuccessStatusCode)
             {
                 await _navigation.PushAsync(new NavigationPage(new UserListView()));
                 /*  JObject user = JObject.Parse(responseString);

                   slUser.IsVisible = true;
                   lblDisplayName.Text = user["displayName"].ToString();
                   lblGivenName.Text = user["givenName"].ToString();
                   lblId.Text = user["id"].ToString();
                   lblSurname.Text = user["surname"].ToString();
                   lblUserPrincipalName.Text = user["userPrincipalName"].ToString();

                   // just in case
                   btnSignInSignOut.Text = "Sign out";


    }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Something went wrong with the API call", responseString, "Dismiss");
            }
        }

     protected override async void OnAppearing()
        {
            // let's see if we have a user in our belly already
            try
            {
                ar =await App.PCA.AcquireTokenSilentAsync(App.Scopes, App.PCA.Users.FirstOrDefault());
                await RefreshUserDataAsync(ar.AccessToken);

            }
            catch (MsalUiRequiredException ex)
            {
                // A MsalUiRequiredException happened on AcquireTokenSilentAsync. 
                // This indicates you need to call AcquireTokenAsync to acquire a token
                System.Diagnostics.Debug.WriteLine($"MsalUiRequiredException: {ex.Message}");

                try
                {
                    ar = await App.PCA.AcquireTokenAsync(App.Scopes);
                }
                catch (MsalException msalex)
                {
                   // ResultText.Text = $"Error Acquiring Token:{System.Environment.NewLine}{msalex}";
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert(ex.Message, "Continue", "OK");
                // doesn't matter, we go in interactive more

            }
        }
        */
        void Handle_Clear_Clicked(object sender, System.EventArgs e)
        {
            /*  Map map = new Map
              {
                  IsShowingUser = true,
                  HeightRequest = 100,
                  WidthRequest = 960,
                  VerticalOptions = LayoutOptions.FillAndExpand

              };
              map.MoveToRegion(MapSpan.FromCenterAndRadius(
                  new Position(36.9628066, -122.0194722), Distance.FromMiles(3))); // Santa Cruz golf course

              var position = new Position(36.9628066, -122.0194722); // Latitude, Longitude
              var pin = new Pin
              {
                  Type = PinType.Place,
                  Position = position,
                  Label = "Santa Cruz",
                  Address = "custom detail info"
              };
              map.Pins.Add(pin);
              Content = new StackLayout
              {
                  Spacing = 0,
                  Children = {
                      map

                  }
              }; */
            if (Device.RuntimePlatform == Device.iOS)
            {
                //https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
                Device.OpenUri(new Uri(string.Format("http://maps.apple.com/?q={0}", WebUtility.UrlEncode("Chennai"))));
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                // opens the Maps app directly
                Device.OpenUri(new Uri(string.Format("geo:0,0?q={0}", WebUtility.UrlEncode("Chennai"))));

            }
            else if (Device.RuntimePlatform == Device.UWP || Device.RuntimePlatform == Device.WinPhone)
            {
                Device.OpenUri(new Uri(string.Format("bingmaps:?where={0}", Uri.EscapeDataString("Chennai"))));
            }
        }
    }
}