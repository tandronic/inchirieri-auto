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
            var masina = new Masini("Audi", "A4", "SV89ABC", 2017, 1986,
                (CuloareMasina)1, (CombustibilMasina)2, (OptiuniMasina)1,
                (OptiuniMasina)2, (OptiuniMasina)3, (OptiuniMasina)4, false);
            Console.WriteLine(masina.ConversieLaSir());
            var masina2 = new Masini("Audi", "A4", "SV89XTC", 2017, 1986, 
                (CuloareMasina)1, (CombustibilMasina)2, [(OptiuniMasina)1, 
                (OptiuniMasina)2, (OptiuniMasina)3, (OptiuniMasina)4], false);
            Console.WriteLine(masina2.ConversieLaSir());
            if (masina.Compare(masina2))
                Console.WriteLine("Este aceiasi masina");
            else
                Console.WriteLine("Cele 2 masini sunt diferite");
            Console.ReadKey();

            // Test clasa Angajati
            var angajat = new Angajati("Popescu", "Ionel", "Adresa test", "0751910763", 30,
                "122334567891", "Marketing", 10, 9, 2019);
            Console.WriteLine(angajat.ConversieLaSir());
            var angajat2 = new Angajati("Popescu", "Ionel", "Adresa test", "0751910763", 30,
                "122334567391", "Marketing", 10, 9, 2019);
            Console.WriteLine(angajat2.ConversieLaSir());
            if (angajat.Compare(angajat2))
                Console.WriteLine("Este acelasi angajat");
            else
                Console.WriteLine("Nu este acelasi angajat");
            Console.ReadKey();

            // Test clasa Clienti
            var client = new Clienti("Popovici", "Georgel", "Adresa test", "Telefon", 23, "1232343247324723",
                "SV89ABC", 23, 12, 2019, 60);
            Console.WriteLine(client.ConversieLaSir());
            Console.ReadKey();
        }
    }
}
