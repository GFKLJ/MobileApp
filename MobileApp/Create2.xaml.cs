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
    public partial class Create2 : ContentPage
    {
        public Create2()
        {
            InitializeComponent();
        }
        private async void Create_VuborRazminka(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create_vuborRazminka());
        }
        private async void Create_VuborOsnova(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create_VuborOsnova());
        }
        private async void Create_VuborZaminka(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create_vuborZaminka());
        }
    }
}