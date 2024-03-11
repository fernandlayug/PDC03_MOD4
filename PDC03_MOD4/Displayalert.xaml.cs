using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD4
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Displayalert : ContentPage
	{
		public Displayalert ()
		{
			InitializeComponent ();
		}

        async void OnALert(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "You have been alerted", "OK");
        }

        async void OnALertOption(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            Debug.WriteLine("Answer: " + answer);
        }

        async void OnActionSheetSimpleClicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
            if (action != null)
            {
                // Handle the selected action
                switch (action)
                {
                    case "Email":
                        // Handle Option 1
                        break;
                    case "Twitter":
                        // Handle Twitter
                        break;
                    case "Facebook":
                        // Handle Facebook
                        await Browser.OpenAsync("https://www.facebook.com/");
                        break;
                }
            }
            else
            {
                // Handle cancellation
            }
        }

        async void OnActionSheetCancelDeleteClicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("ActionSheet: SavePhoto?", "Cancel", "Delete", "Photo Roll", "Email");
            Debug.WriteLine("Action: " + action);
        }

        async void OnQuestion1ButtonClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "What's your name?", initialValue: string.Empty);
            if (!string.IsNullOrWhiteSpace(result))
            {
                question1ResultLabel.Text = $"Hello {result}.";
            }
        }

        async void OnQuestion2ButtonClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "What's 5 + 5?", initialValue: "10", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                question2ResultLabel.Text = number == 10 ? "Correct." : "Incorrect.";
            }
        }
    }
}