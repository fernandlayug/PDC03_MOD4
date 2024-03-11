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
    public partial class Activity3 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public Activity3()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Juan Dela Cruz", Position = "President", Image = "image1.jpg" });
            employees.Add(new Employee { DisplayName = "Liwayway Cruz", Position = "Vice President", Image = "https://thumbs-prod.si-cdn.com/o6o5GUuWyPPvZsStbI2iElKRSm0=/800x600/filters:no_upscale()/https://public-media.si-cdn.com/filer/36/e1/36e12c18-426f-4639-a3f0-39599edbed4d/42-56243662.jpg" });
            employees.Add(new Employee { DisplayName = "john Dee", Position = "Director", Image = "image3.jpg" });
            employees.Add(new Employee { DisplayName = "Mark Cruz", Position = "Supervisor", Image = "image4.jpg" });
            employees.Add(new Employee { DisplayName = "Peter Doe", Position = "Manager", Image = "image5.jpg" });
        }
    }
}