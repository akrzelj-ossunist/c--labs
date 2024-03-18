/*
WPF stands for Windows Presentation Foundation.
It is a graphical subsystem developed by Microsoft for rendering user interfaces in Windows-based applications.
WPF is part of the .NET Framework and provides a unified programming model for building desktop applications, 
including rich user interfaces, graphics, multimedia, and documents.
*/
class Program
{
    public static void Main()
    {
        Patient mate = new("12345678910", "123456789", "Mate Matic", DateTime.Parse("1990-05-15"), "Male", "Sick AF");

        Patient ana = new("12345678912", "123456743", "Ana Anic", DateTime.Parse("1996-01-16"), "Female", "Dont wanna go to work!");

        Patient jimmy = new("43345678942", "126556743", "Jimmy Johnny", DateTime.Parse("4996-01-16"), "Male", "Broken leg!");

        Hospital hospital = new();

        hospital.Add(mate);
        hospital.Add(ana);
        hospital.Add(jimmy);

        hospital.Print();

        hospital.Remove(ana.OIB);

        hospital.Print();

        jimmy.Gender = "Female";

        hospital.Edit(jimmy);

        hospital.Print();
    }
}