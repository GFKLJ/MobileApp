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
    public partial class Create : ContentPage
    {
        public Create()
        {
            InitializeComponent();
        }

        private async void Create1(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int q = 0;
            int i = 0;
            int v = 0;
            if (check1.IsChecked == true)
                a++;
            if (check2.IsChecked == true)
                b++;
            if (check3.IsChecked == true)
                c++;
            if (check4.IsChecked == true)
                d++;
            if (check5.IsChecked == true)
                q++;
            if (check6.IsChecked == true)
                i++;
            if (check7.IsChecked == true)
                v++;
            int l = a + b + c + d + q + i + v;
            if (l < 3)
            {
                await DisplayAlert("Упс...", "Пожалуйста, выберите дни для своего графика, не менее 3", "ок");
            }
            else
            {
                await Navigation.PushAsync(new Create1());
            }

        }

        private void Create0_Checked1(object sender, CheckedChangedEventArgs e)
        {

        }
        private void Create0_Checked2(object sender, CheckedChangedEventArgs e)
        {

        }
        private void Create0_Checked3(object sender, CheckedChangedEventArgs e)
        {

        }
        private void Create0_Checked4(object sender, CheckedChangedEventArgs e)
        {

        }
        private void Create0_Checked5(object sender, CheckedChangedEventArgs e)
        {

        }
        private void Create0_Checked6(object sender, CheckedChangedEventArgs e)
        {

        }
        private void Create0_Checked7(object sender, CheckedChangedEventArgs e)
        {

        }


    }
}