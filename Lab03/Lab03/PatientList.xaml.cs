using System.Windows;
using System.Windows.Controls;

namespace Lab03
{
    public partial class PatientList : Window
    {

        public Hospital Hospital { get; set; }
        public EditPatientForm EditPatientForm { get; set; }

        public PatientList(Hospital hospital)
        {
            InitializeComponent();

            Hospital = hospital;

            DataContext = Hospital;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Patient patient = (Patient)button.DataContext;

            string oib = patient.OIB;
            EditPatientForm = new EditPatientForm(Hospital, oib);
            EditPatientForm.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Patient patient = (Patient)button.DataContext;

            string oib = patient.OIB;
            Hospital.Remove(oib);
        }
    }
}
