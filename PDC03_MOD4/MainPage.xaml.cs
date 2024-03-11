using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_MOD4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Activity01Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity1());
        }
        private async void Activity02Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity2());
        }

        private async void Activity02bPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity2b());
        }

        private async void Activity02cPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity2c());
        }

        private async void Activity02dPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity2d());
        }
        private async void Activity03Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity3());
        }
        private async void Activity04Page(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Activity4());
        }
        private async void Activity05Page(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Activity5());
        }

        private async void Activity06Page(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Displayalert());
        }

    }
}
