using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DemoEmployee
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // define view model from UI
        public EmployeeViewModel ViewModel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            // initialize view model
            this.ViewModel = new EmployeeViewModel();
        }

        // show selected employees name below list view
        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Employee employee = (Employee)e.ClickedItem;
            ResultTextBlock.Text = "Selected employee: " + employee.Firstname + " " + employee.Lastname;
        }
    }
}
