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

namespace Lab03
{
    public partial class EditPatientForm : Window
    {
        public Hospital Hospital { get; set; }
        public string Oib { get; set; }
        public Patient Patient { get; set; }

        public EditPatientForm(Hospital hospital, string oib)
        {
            InitializeComponent();

            Hospital = hospital;
            Oib = oib;

            Patient = Hospital.FindByOib(Oib);

            DataContext = Patient;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            Patient EditedPatient = new Patient(OibText.Text, MboText.Text, NameText.Text, BdayText.SelectedDate.GetValueOrDefault(), ((ComboBoxItem)GenderComboBox.SelectedItem).Content.ToString(), DiagnosisText.Text);
            Hospital.Edit(EditedPatient);
            PatientList patientList = new PatientList(Hospital);
            patientList.Show();
            this.Close();
        }
    }
}
