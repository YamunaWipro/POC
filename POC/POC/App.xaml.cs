using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using POC.ViewModels;
namespace POC
{
    public static class ViewModelLocator
    {
        static UserListViewModel monkeysVM;
        public static UserListViewModel MonkeysViewModel
        => monkeysVM ?? (monkeysVM = new UserListViewModel());

        static DetailsViewModel detailsVM;
        public static DetailsViewModel DetailsViewModel
        => detailsVM ?? (detailsVM = new DetailsViewModel(UserDetailsHelper.Monkeys[0]));
    }
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
