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

        public Patient NewPatient { get; private set; }

        public PatientForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Validate the input fields
            if (!ValidateInputs())
            {
                MessageBox.Show("Please fill in all required fields correctly.");
                return;
            }

            NewPatient = new Patient(OibText.Text, MboText.Text, NameText.Text, BdayText.SelectedDate.GetValueOrDefault(), ((ComboBoxItem)GenderComboBox.SelectedItem).Content.ToString(), DiagnosisText.Text);

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
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

