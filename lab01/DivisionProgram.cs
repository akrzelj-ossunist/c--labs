using System;

class DivisionProgram
{
    public static void Run()
    {

        try
        {
            // Upis prvog broja
            Console.Write("Upiši prvi cijeli broj: ");
            string prviBrojString = Console.ReadLine();
            int prviBroj;

            // Provjera da li je unos ispravan
            if (!int.TryParse(prviBrojString, out prviBroj))
            {
                Console.WriteLine("Neispravan unos prvog broja.");
                return;
            }

            // Upis drugog broja
            Console.Write("Upiši drugi cijeli broj: ");
            string drugiBrojString = Console.ReadLine();
            int drugiBroj;

            // Provjera da li je unos ispravan
            if (!int.TryParse(drugiBrojString, out drugiBroj))
            {
                Console.WriteLine("Neispravan unos drugog broja.");
                return;
            }

            double rezultat = (double)prviBroj / drugiBroj;

            Console.WriteLine("Rezultat dijeljenja:");
            Console.WriteLine("Currency: {0:C}", rezultat);
            Console.WriteLine("Integer: {0}", (int)rezultat);
            Console.WriteLine("Scientific: {0:E}", rezultat);
            Console.WriteLine("Fixed-point: {0:F}", rezultat);
            Console.WriteLine("General: {0:G}", rezultat);
            Console.WriteLine("Number: {0:N}", rezultat);
            Console.WriteLine("Hexadecimal: {0:X}", (int)rezultat);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Došlo je do greške: " + ex.Message);
        }
    }
}