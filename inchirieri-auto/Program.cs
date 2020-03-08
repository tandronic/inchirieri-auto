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
            var masina = new Masini("Audi", "A4", "WAUZZZF49HA036784", 2017, 1986, false);
            Console.WriteLine(masina.Info());
            Console.ReadKey();
            var angajat = new Angajati("Popescu", "Ionel", "Adresa test", "0751910763", 30,
                "122334567891", "Marketing", 10, 9, 2019);
            Console.WriteLine(angajat.Info());
            Console.ReadKey();
            var client = new Clienti("Popovici", "Georgel", "Adresa test", "Telefon", 23, "1232343247324723",
                "WAUZZZF49HA036784", 23, 12, 2019, 60);
            Console.WriteLine(client.Info());
            Console.ReadKey();
        }
    }
}
