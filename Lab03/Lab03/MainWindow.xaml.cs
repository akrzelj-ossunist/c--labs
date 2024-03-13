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
/* 
 plan kreirati usera preko forme u PatientForm i od tamo kreiranog usera poslat u MainWindow ali kada ga posaljem main window se ni ne otvori
 */
namespace Lab03
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PatientForm patientForm = new PatientForm();
            patientForm.ShowDialog();
            Patient newPatient = patientForm.NewPatient;
            if (newPatient != null)
            {
                Menu(newPatient);
            }
        }

        public void Menu(Patient patient)
        {
            Hospital hospital = new Hospital();
            hospital.Add(patient);
            hospital.Print();
        }

        private void RedirectToPatientForm_Click(object sender, RoutedEventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
            this.Close();
        }
    }
}
