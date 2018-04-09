using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POC.Model;
using POC.View;
using POC.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POC.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsView : ContentPage
	{
		public DetailsView (DetailsModel monkey)
		{
			InitializeComponent ();
		}
	}
}