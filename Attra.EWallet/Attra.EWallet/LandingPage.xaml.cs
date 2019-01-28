using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Attra.EWallet
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LandingPage : ContentPage
	{
		public LandingPage ()
		{
			InitializeComponent ();
		}

        private async void Logout_OnClicked(object sender, EventArgs e)
        {
            //  var model = new LoginViewModel();
            //  this.BindingContext = model;

          
                await Navigation.PushModalAsync(new LoginPage());

        }
    }
}