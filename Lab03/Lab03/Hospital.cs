using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Hospital
    {
        public ObservableCollection<Patient> Patients { get; set; } = new ObservableCollection<Patient>();

        public void Add(Patient patient)
        {
            Patients.Add(patient);
        }

        public void Remove(string OIB)
        {
            Patient patientToRemove = Patients.FirstOrDefault(p => p.OIB == OIB);

            if (patientToRemove != null)
            {
                Patients.Remove(patientToRemove);
            }
        }

        public void Edit(Patient patientDto)
        {
            Patient patient = Patients.FirstOrDefault(p => p.OIB == patientDto.OIB);

            Remove(patient.OIB);

            patient.OIB = patientDto.OIB ?? patient.OIB;
            patient.MBO = patientDto.MBO ?? patient.MBO;
            patient.FullName = patientDto.FullName ?? patient.FullName;
            patient.Birthday = patientDto.Birthday == null ? patient.Birthday : patientDto.Birthday;
            patient.Gender = patientDto.Gender ?? patient.Gender;
            patient.Diagnosis = patientDto.Diagnosis ?? patient.Diagnosis;

            Add(patient);
        }

        public Patient FindByOib(string OIB)
        {
            return Patients.FirstOrDefault(p => p.OIB == OIB);
        }

        public void Print()
        {
            Console.WriteLine("\nPatients:");
            foreach (var patient in Patients)
            {
                Console.WriteLine($"\nOIB: {patient.OIB}, \nMBO: {patient.MBO}, \nFull Name: {patient.FullName}, \nBirthday: {patient.Birthday}, \nGender: {patient.Gender}, \nDiagnosis: {patient.Diagnosis}");
            }
        }
    }
}
