﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity4Page2 : ContentPage
    {
        public Activity4Page2()
        {
            InitializeComponent();
        }
        private async void onPreviousPage(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
      }

    }
}