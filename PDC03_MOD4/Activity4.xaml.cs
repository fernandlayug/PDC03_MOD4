using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity4 : ContentPage
    {
        public Activity4()
        {
            InitializeComponent();
        }

        private async void onNextPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Activity4Page2());
        }
        private async void onPreviousPage(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}