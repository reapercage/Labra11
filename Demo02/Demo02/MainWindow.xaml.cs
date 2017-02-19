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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
    public partial class MainWindow : Window
    {
        public string Nimi { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Nimi = "Julle";
            teksti.DataContext = this;

            Person persoona = new Person { Firstname = "Julle", Lastname = "Ankanpää" };
            spPerson.DataContext = persoona;

        }
    }
}
