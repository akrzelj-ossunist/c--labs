using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace Lab03
{
    public partial class MainWindow : Window
    {

        public Patient Patient { get; set; }
        public Hospital Hospital { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Hospital = new Hospital();
        }

        public void Menu()
        {
            Hospital.Add(Patient);
            Hospital.Print();
        }

        private void RedirectToPatientForm_Click(object sender, RoutedEventArgs e)
        {
            PatientForm patientForm = new PatientForm(this);
            patientForm.Show();
            this.Hide();
        }

        private void RedirectToPatientList_Click(object sender, RoutedEventArgs e)
        {

            PatientList patientList = new PatientList(Hospital);
            patientList.Show();
            this.Hide();
        }
    }
}
