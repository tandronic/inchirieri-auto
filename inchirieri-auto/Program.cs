using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchirieri_auto
{
    class Program
    {
        static string Meniu()
        {
            string meniu;
            meniu = "M - Citire masina tastatura\n";
            meniu += "A - Citire angajat tastatura\n";
            meniu += "C - Citire client tastatura\n";
            meniu += "F - Afisare masini\n";
            meniu += "T - Test masini\n";
            meniu += "X - Exit";
            return meniu;
        }

        static void Main(string[] args)
        {
            string FisierMasini = "masini.txt";
            FileManager adminMasini = new FileManager(FisierMasini);
            int NrMasini;
            Masini[] MasiniFisier = adminMasini.GetMasini(out NrMasini);

            do
            {
                Console.Clear();
                Console.WriteLine(Meniu());
                string optiune = Console.ReadLine();
                optiune = optiune.ToUpper();
                switch(optiune)
                {
                    case "M":
                        string mesaj;
                        mesaj = "Brend, Model, Nr. Inmatriculare, An, Capacitate Motor, Culoare:\n1.Alb\n";
                        mesaj += "2.Negru\n3.Albastru\n4.Verde\n5.Portocaliu\n6.Galben,";
                        mesaj += "Motorizare:\n1.Benzina\n2.Diesel\n3.Electrica, Inghiriata: 0 Nu 1 Da";
                        Console.WriteLine(mesaj);
                        // var masina = new Masini(Console.ReadLine());
                        var masina = new Masini("Audi", "A4", "SV89ABC", 2017, 1986, (CuloareMasina)1, (CombustibilMasina)2, false);
                        MasiniFisier[NrMasini] = masina;
                        NrMasini++;
                        adminMasini.AddMasini(masina);
                        Console.ReadLine();
                        break;
                    case "A":
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
                        break;
                    case "C":
                        var client = new Clienti("Popovici", "Georgel", "Adresa test", "Telefon", 23, "1232343247324723",
                            "SV89ABC", 23, 12, 2019, 60);
                        var client2 = new Clienti("Popovici", "Georgel", "Adresa test", "Telefon", 23, "1232343247324723",
                            "SV89ABC", 23, 12, 2019, 60);
                        Console.WriteLine(client.ConversieLaSir());
                        Console.WriteLine(client2.ConversieLaSir());
                        if (client.Compare(client2))
                            Console.WriteLine("Este acelasi angajat");
                        else
                            Console.WriteLine("Nu este acelasi angajat");
                        Console.ReadKey();
                        break;
                    case "T":
                       var masina1 = new Masini("Audi", "A4", "SV89ABC", 2017, 1986, (CuloareMasina)1, 
                           (CombustibilMasina)2, false);
                        Console.WriteLine(masina1);
                        var masina2 = new Masini("Audi", "A4", "SV89XTC", 2017, 1986,
                            (CuloareMasina)3, (CombustibilMasina)3, false);
                        Console.WriteLine(masina2.ConversieLaSir());
                        if (masina1.Compare(masina2))
                            Console.WriteLine("Este aceiasi masina");
                        else
                            Console.WriteLine("Cele 2 masini sunt diferite");
                        Console.ReadKey();
                        break;
                    case "F":
                        for(int i=0; i < NrMasini; i++)
                            Console.WriteLine(MasiniFisier[i].ConversieLaSir());
                        Console.ReadKey();
                        break;
                    case "X":
                        System.Environment.Exit(1);
                        break;
                }
            } while (true);
        }
    }
}
