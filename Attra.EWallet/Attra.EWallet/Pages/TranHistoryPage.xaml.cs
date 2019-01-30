using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Attra.EWallet.Pages
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TranHistoryPage : ContentPage
	{
		public TranHistoryPage ()
		{
			InitializeComponent ();
            lbldate.Text = DateTime.Now.ToString("dd MMM,yyyy.hh:mm tt.");
            lbltime.Text = DateTime.Now.ToShortTimeString();
		}
	}
    //public String datetime;
    //public class DateTime
    //{
      //  get{return DateTime};
}