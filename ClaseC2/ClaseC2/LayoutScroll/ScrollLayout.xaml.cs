using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutScroll
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScrollLayout : ContentPage
	{
		public ScrollLayout ()
		{
			InitializeComponent ();
		}

         private void scroll_btn(object sender, EventArgs e)
        {
            miScroll.ScrollToAsync(0, 1000, true); 

          
        }
    }
}