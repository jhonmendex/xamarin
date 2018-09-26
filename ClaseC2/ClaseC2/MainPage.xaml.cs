using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClaseC2
{
	public partial class MainPage : ContentPage
	{
        public String usuario = "jhon";

        public MainPage()
        {
            InitializeComponent();

        }

        async private void sliders(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new onSlider.slider());
        }

        async private void grid(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grid.Grid1());
        }

        async private void boxLayout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoxLayout.BoxLayout());
        }

        async private void diccionario(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Diccionarios.Diccionario());
        }

        async private void absoluteLayout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LayoutAbsolute.AbsoluteLayout());
        }

        async private void relativeLayout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LayoutRelative.RelativeLayout());
        }

        async private void scrollLayout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LayoutScroll.ScrollLayout());
        }

        async private void animations(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Animations.Animation());
        }

        async private void estilos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estilos.Estilos());
        }
        async private void ingresarBtn(object sender, EventArgs e)
        {
            if (usuario == usuraioTxt.Text)
            {
                await DisplayAlert("Hola mundo", "hola mundo", "ok");
            }
            await Navigation.PushAsync(new Estilos.Estilos());
        }
    }
}
