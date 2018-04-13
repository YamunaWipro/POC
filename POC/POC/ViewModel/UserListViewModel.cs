using POC;
using POC.Model;
using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using System;
using System.Net;

namespace POC
{
    public class UserListViewModel : INotifyPropertyChanged
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
        public ObservableCollection<DetailsModel> Monkeys { get; set; }
        public ObservableCollection<Grouping<string, DetailsModel>> MonkeysGrouped { get; set; }
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
        public UserListViewModel()
        {

            Monkeys = UserDetailsHelper.Monkeys;
            ViewLocation = new Command(showlocation);
        }

        public int MonkeyCount => Monkeys.Count;
        void showlocation()
        {
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
        public Command ViewLocation { get; set; }

    }

}
