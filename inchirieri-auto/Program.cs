using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchirieri_auto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test clasa Masini
            var masina = new Masini("Audi", "A4", "SV89ABC", 2017, 1986, false);
            Console.WriteLine(masina.ConversieLaSir());
            Console.ReadKey();

            // Test clasa Angajati
            var angajat = new Angajati("Popescu", "Ionel", "Adresa test", "0751910763", 30,
                "122334567891", "Marketing", 10, 9, 2019);
            Console.WriteLine(angajat.ConversieLaSir());
            Console.ReadKey();

            // Test clasa Clienti
            var client = new Clienti("Popovici", "Georgel", "Adresa test", "Telefon", 23, "1232343247324723",
                "SV89ABC", 23, 12, 2019, 60);
            Console.WriteLine(client.ConversieLaSir());
            Console.ReadKey();
        }
    }
}
