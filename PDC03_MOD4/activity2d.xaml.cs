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
	public partial class activity2d : ContentPage
	{
		public activity2d ()
		{
			InitializeComponent ();
		}
        void OnSubmitEntry(object sender, EventArgs e)
        {
            string entry1Text = fname.Text;
            string entry2Text = lname.Text;
            string entry3Text = myEmail.Text;

            DisplayAlert("Entered Values", $"Entry 1: {entry1Text}\nEntry 2: {entry2Text}\nEntry 3: {entry3Text}\nEntry Are you sure you", "OK");
        }
    }
}