public class Hospital
{
    private List<Patient> patients = new List<Patient>();

    public void Add(Patient patient)
    {
        patients.Add(patient);
    }

    public void Remove(string OIB)
    {
        Patient patient = patients.Find(el => el.OIB == OIB);

        if (patient != null) patients.Remove(patient);
    }

    public void Edit(Patient patientDto)
    {
        Patient patient = patients.Find(el => el.OIB == patientDto.OIB);

        Remove(patient.OIB);

        patient.OIB = patientDto.OIB ?? patient.OIB;
        patient.MBO = patientDto.MBO ?? patient.MBO;
        patient.FullName = patientDto.FullName ?? patient.FullName;
        patient.Birthday = patientDto.Birthday == null ? patient.Birthday : patientDto.Birthday;
        patient.Gender = patientDto.Gender ?? patient.Gender;
        patient.Diagnosis = patientDto.Diagnosis ?? patient.Diagnosis;

        Add(patient);
    }

    public void Print()
    {
        Console.WriteLine("\nPatients:");
        foreach (var patient in patients)
        {
            Console.WriteLine($"\nOIB: {patient.OIB}, \nMBO: {patient.MBO}, \nFull Name: {patient.FullName}, \nBirthday: {patient.Birthday}, \nGender: {patient.Gender}, \nDiagnosis: {patient.Diagnosis}");
        }
    }
}