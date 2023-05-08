using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Create1 : ContentPage
    {
        public Create1()
        {
            InitializeComponent();
        }

        private async void Create2(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            if (check1.IsChecked == true)
                a++;
            if (check2.IsChecked == true)
                b++;
            if (check3.IsChecked == true)
                c++;
            if (check4.IsChecked == true)
                d++;

            int i = a + b + c + d;
            if (i < 3)
            {
                await DisplayAlert("Упс...", "Пожалуйста, выберите недели для своего графика, не менее 3", "ок");
            }
            else
            {
                await Navigation.PushAsync(new Create2());
            }


        }


    }
}