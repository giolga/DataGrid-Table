using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Employee mixo = new Employee(1, "John", "9 April st.", "Gurjaani", "Kakheti");
            Employee kumi = new Employee(2, "El Kumi", "Grove Street", "Harlem", "New York");

            DataGridXAML.Items.Add(mixo);
            DataGridXAML.Items.Add(kumi);
        }

        private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IdTB.Text.Trim().Equals(""))
            {
                IdTB.Background = Brushes.Pink;
                if (MessageBox.Show("Empty Field!\nPLease Enter the EmployeeId", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    IdTB.Background = Brushes.Transparent;
                }
            }

            else if (NameTB.Text.Trim().Equals(""))
            {
                NameTB.Background = Brushes.Pink;
                if (MessageBox.Show("Empty Field!\nPLease Enter the Employee name", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    NameTB.Background = Brushes.Transparent;
                }
            }

            else if (AddrTB.Text.Trim().Equals(""))
            {
                AddrTB.Background = Brushes.Pink;
                if (MessageBox.Show("Empty Field!\nPLease Enter the Employee address", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    AddrTB.Background = Brushes.Transparent;
                }
            }

            else if (CityTB.Text.Trim().Equals(""))
            {
                CityTB.Background = Brushes.Pink;
                if (MessageBox.Show("Empty Field!\nPLease Enter the Employee city", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    CityTB.Background = Brushes.Transparent;
                }
            }

            else if (StateTb.Text.Trim().Equals(""))
            {
                StateTb.Background = Brushes.Pink;
                if (MessageBox.Show("Empty Field!\nPLease Enter the Employee state", "Error", MessageBoxButton.OK) == MessageBoxResult.OK)
                {
                    StateTb.Background = Brushes.Transparent;
                }
            }

            else
            {
                Employee addEmployee = new Employee(int.Parse(IdTB.Text.ToString()), NameTB.Text.ToString(), AddrTB.Text.ToString(), CityTB.Text.ToString(), StateTb.Text.ToString());
                DataGridXAML.Items.Add(addEmployee);

                IdTB.Text = "";
                NameTB.Text = "";
                AddrTB.Text = "";
                CityTB.Text = "";
                StateTb.Text = "";
            }

        }
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeState { get; set; }

        public Employee(int id, string name, string address, string city, string state)
        {
            EmployeeId = id;
            Name = name;
            EmployeeAddress = address;
            EmployeeCity = city;
            EmployeeState = state;

        }
    }

}
