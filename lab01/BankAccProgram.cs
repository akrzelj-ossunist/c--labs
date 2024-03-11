using System;

// Pobrojani tip podataka za vrste računa
enum VrstaRacuna
{
    Štednja,
    TekućiRačun,
    ŽiroRačun
}

// Struktura za bankovni račun
struct BankAccount
{
    public int BrojRacuna;
    public decimal IznosNaRacunu;
    public VrstaRacuna VrstaRacuna;
}

class BankAccProgram
{
    public static void Run()
    {
        // Deklariranje polja struktura BankAccount od 5 elemenata
        BankAccount[] racuni = new BankAccount[5];
        int brojRacuna = 0;

        while (true)
        {
            // Ispis izbornika
            Console.WriteLine("Izaberite opciju:");
            Console.WriteLine("1. Upis novog računa");
            Console.WriteLine("2. Ispis svih računa");
            Console.WriteLine("3. Izlaz");

            // Čitanje odabira korisnika
            string odabir = Console.ReadLine();

            switch (odabir)
            {
                case "1":
                    if (brojRacuna < racuni.Length)
                    {
                        // Unos novog računa
                        Console.WriteLine("Unesite broj računa:");
                        int broj = int.Parse(Console.ReadLine());

                        Console.WriteLine("Unesite iznos na računu:");
                        decimal iznos = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Odaberite vrstu računa (0 za Štednju, 1 za Tekući račun, 2 za Žiro račun):");
                        VrstaRacuna vrsta = (VrstaRacuna)int.Parse(Console.ReadLine());

                        // Dodavanje novog računa u polje
                        racuni[brojRacuna] = new BankAccount { BrojRacuna = broj, IznosNaRacunu = iznos, VrstaRacuna = vrsta };
                        brojRacuna++;
                    }
                    else
                    {
                        Console.WriteLine("Nema dovoljno prostora za nove račune.");
                    }
                    break;
                case "2":
                    // Ispis svih računa
                    Console.WriteLine("Svi računi:");
                    foreach (var racun in racuni)
                        Console.WriteLine($"Broj računa: {racun.BrojRacuna}, Iznos na računu: {racun.IznosNaRacunu}, Vrsta računa: {racun.VrstaRacuna}");
                    break;
                case "3":
                    // Izlaz iz programa
                    Console.WriteLine("Izlaz iz programa.");
                    return;
                default:
                    Console.WriteLine("Neispravan odabir.");
                    break;
            }
        }
    }
}
