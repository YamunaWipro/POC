//using Android.Content.Res;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using System.Net.Http;
using System.Linq;
using POC.View;
using POC;

namespace POC.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        DatabaseHelper dh;
        
        public String name;
        public string username, password;
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        public INavigation _navigation;
        public string pathName;
        private string _username, _password;
        AuthenticationResult ar;
        public LoginViewModel()
        {
           

            dh = new DatabaseHelper();
           
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            InputClearCommand = new Command(Validation);
          
        }
        public string Username { get { return _username; }
             set {
                _username = value; OnPropertyChanged("Username");
            } }
        public string Password { get { return _password; }  set {
                _password = value;
                OnPropertyChanged("Password");
               
            } }
        void Validation()
        {
            Username = string.Empty;
            Password = string.Empty;
           // loginModel.Username = string.Empty;
          //  loginModel.Password = string.Empty;
           OnPropertyChanged("Username");
            OnPropertyChanged("Password");
           // this.OnPropertyChanged("loginModel.Password");
        }
        public  async Task RefreshUserDataAsync(string token)
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
                  btnSignInSignOut.Text = "Sign out";*/


            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Something went wrong with the API call", responseString, "Dismiss");
            }
        }


        async Task ExecuteLoadItemsCommand()
        {
          /*  try
            {
                ar = await App.PCA.AcquireTokenSilentAsync(App.Scopes, App.PCA.Users.FirstOrDefault());
                await RefreshUserDataAsync(ar.AccessToken);

            }
            catch (MsalUiRequiredException ex)
            {
                // A MsalUiRequiredException happened on AcquireTokenSilentAsync. 
                // This indicates you need to call AcquireTokenAsync to acquire a token
                System.Diagnostics.Debug.WriteLine($"MsalUiRequiredException: {ex.Message}");

                try
                {
                    ar = await App.PCA.AcquireTokenAsync(App.Scopes,App.UiParent);
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




            // let's see if we have a user in our belly already
            /* try
              {
                  AuthenticationResult ar = await App.PCA.AcquireTokenAsync(App.Scopes, App.UiParent);
                 await RefreshUserDataAsync(ar.AccessToken);

              }
              catch (Exception ex)
              {
                  await Application.Current.MainPage.DisplayAlert(ex.Message, "Continue", "OK");
              } */
            //--------------------------------------------------------------------------------------
               username =_username;
               password = _password;
               //((m.usernameEntry.Text).Equals(string.Empty))
               //   await Application.Current.MainPage.DisplayAlert(MainPage.usernameEntry.Text, "Continue", "OK")
               if (username.Equals(string.Empty) || password.Equals(string.Empty))
               {

                   await Application.Current.MainPage.DisplayAlert("Username or Password is empty", "Continue", "OK");
               }
               else

               {


                   string pass = dh.GetPassword(username);
                   if (pass.Equals(""))
                   {
                       await Application.Current.MainPage.DisplayAlert("Username is incorrect", "Continue", "OK");
                   }
                   else
                   {
                       if (pass.Equals(password))
                           //  await Application.Current.MainPage.DisplayAlert(n, "Continue", "OK");
                           // else
                           //  await Application.Current.MainPage.DisplayAlert("No", "Continue", "OK");
                           await _navigation.PushAsync(new NavigationPage(new UserListView()));
                       else
                           await Application.Current.MainPage.DisplayAlert("Password is incorrect", "Continue", "OK");
                   }
               }
               //await Application.Current.MainPage.DisplayAlert("Negotiation", "Saved correctly", "OK");*/

        }


       
        public Command LoadItemsCommand { get ; set; }
        public ICommand InputClearCommand { get; private set; }

    }
}
    
