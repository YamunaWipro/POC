using Xamarin.Forms;
using POC.View;
using POC.ViewModels;
using System;

namespace POC
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
             InitializeComponent();
            LoginViewModel viewmodel = new LoginViewModel();
            BindingContext = viewmodel;
           
                
            viewmodel._navigation = this.Navigation;
        }

       

        void Handle_Clear_Clicked(object sender, System.EventArgs e)
        {
            usernameEntry.Text = string.Empty;
            passwordEntry.Text = string.Empty;
        }
      
    }
}
