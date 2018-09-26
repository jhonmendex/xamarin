using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Animations
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Animation : ContentPage
	{
		public Animation ()
		{
			InitializeComponent ();
         /*   MiImagen.Source = new UriImageSource()
            {
                Uri = new Uri("http://imagenes.catholic.net/imagenes_db/3da2fb_homerosimpson.jpg")
            };*/

		}

        private void rotar(object sender, EventArgs e)
        {

        }

        private void transladar(object sender, EventArgs e)
        {

        }

        private void escalar(object sender, EventArgs e)
        {

        }

        private void desvanecer(object sender, EventArgs e)
        {

        }

       async  private void girar(object sender, EventArgs e)
        {
            await miLabel.RotateTo(360, 1000);
            miLabel.Rotation = 0;
        }
    }
}