﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => App.Current.MainPage.Navigation.PushAsync(new UserDetailSingleView((DetailsModel)e.Item));
    }
}