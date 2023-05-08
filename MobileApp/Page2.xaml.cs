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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void Program_Now(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProgramNow());


        }

        private async void Create_Program(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create());
        }



    }
}