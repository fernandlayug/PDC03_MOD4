using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity2 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }
        
        public Activity2()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Juan Dela Cruz", Position="President", Image="image1.jpg" });
            employees.Add(new Employee { DisplayName = "Liwayway Cruz", Position="Vice President", Image = "https://thumbs-prod.si-cdn.com/o6o5GUuWyPPvZsStbI2iElKRSm0=/800x600/filters:no_upscale()/https://public-media.si-cdn.com/filer/36/e1/36e12c18-426f-4639-a3f0-39599edbed4d/42-56243662.jpg" });
            employees.Add(new Employee { DisplayName = "john Dee", Position="Director", Image = "image3.jpg" });
            employees.Add(new Employee { DisplayName = "Mark Cruz", Position="Supervisor", Image = "image4.jpg" });
            employees.Add(new Employee { DisplayName = "Peter Doe", Position="Manager", Image = "image5.jpg" });

        }

        private void MenuAdd(object sender, EventArgs e)
        {
           var menuItem = sender as MenuItem;
            if(menuItem != null)
            {
                var name = menuItem.BindingContext as string;
                DisplayAlert("Alert", "Add " + name, "Ok");
            }
        }
        private void MenuEdit(object sender, EventArgs e)
        {
            //var menuItem = sender as MenuItem;
            //if (menuItem != null)
            //{
            //    var nameentry = menuItem.BindingContext as string;
            //    DisplayAlert("Alert", "Add " + nameentry, "Ok");
            //}
            var menuItem = sender as MenuItem;
            var name = menuItem.CommandParameter as Employee;
            DisplayAlert("Alert","Edit" + name, "OK");
        }
        private void MenuDelete(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {
                var nameentry = menuItem.BindingContext as string;
                DisplayAlert("Alert", "Add " + nameentry, "Ok");
            }
        }
    }
}