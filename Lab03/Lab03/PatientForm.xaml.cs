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
using System.Windows.Shapes;

namespace Lab03
{
    public partial class PatientForm : Window
    {

        public Patient NewPatient { get; set; }

        public MainWindow MainWindow { get; set; }

        public PatientForm(MainWindow mainWindow)
        {
            InitializeComponent();
            MainWindow = mainWindow;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            NewPatient = new Patient(OibText.Text, MboText.Text, NameText.Text, BdayText.SelectedDate.GetValueOrDefault(), ((ComboBoxItem)GenderComboBox.SelectedItem).Content.ToString(), DiagnosisText.Text);

            MainWindow.Patient = NewPatient;
            MainWindow.Menu();
            MainWindow.Show();
            this.Close();
        }
        private bool ValidateInputs()
        {
            var validationContext = new ValidationContext(this);
            var validationResults = new System.Collections.Generic.List<System.ComponentModel.DataAnnotations.ValidationResult>();

            bool isValid = Validator.TryValidateObject(this, validationContext, validationResults, true);

            if (!isValid)
            {
                foreach (var validationResult in validationResults)
                {
                    MessageBox.Show(validationResult.ErrorMessage);
                }
            }

            return isValid;
        }
    }
}

