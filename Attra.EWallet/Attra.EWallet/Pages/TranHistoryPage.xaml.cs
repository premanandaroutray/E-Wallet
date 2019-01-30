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
            CurDateTime.Text = DateTime.Now.ToString("dd MMM,yyyy.hh:mm tt.");
		}
	}
}