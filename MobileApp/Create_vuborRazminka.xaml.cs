using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Razminka;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Create_vuborRazminka : ContentPage
    {
        public Create_vuborRazminka()
        {
            InitializeComponent();
        }

        private async void Opis1_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_1());
        }
        private async void Opis1_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_2());
        }
        private async void Opis1_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_3());
        }
        private async void Opis1_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_4());
        }
        private async void Opis1_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_5());
        }
        private async void Opis1_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_6());
        }
        private async void Opis1_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_7());
        }
        private async void Opis1_8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_8());
        }
        private async void Opis1_9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_9());
        }
        private async void Opis1_10(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_10());
        }
        private async void Opis1_11(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opis1_11());
        }

    }
}