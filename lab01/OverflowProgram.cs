using System;

class OverflowProgram
{
    public static void Run()
    {
        try
        {
            // Postavljanje varijable tipa int na maksimalnu vrijednost za tip long
            int varInt = int.MaxValue;

            // Postavljanje varijable tipa long na maksimalnu vrijednost za tip long
            long varLong = long.MaxValue;

            // Pridruživanje varijable tipa long varijabli tipa int
            varInt = checked((int)varLong);

            Console.WriteLine("Nema preljeva. Rezultat: " + varInt);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Došlo je do preljeva.");
        }
    }
}