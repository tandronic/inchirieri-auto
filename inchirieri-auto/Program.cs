using System;
using System.Collections;
using LibrarieModele;
using NivelAccesDate;


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

        public static void Main(string[] args)
        {
            IStocareData adminMasini = StocareFactory.GetAdministratorStocare();
            do
            {
                Console.Clear();
                Console.WriteLine(Meniu());
                string optiune = Console.ReadLine();
                optiune = optiune.ToUpper();
                switch(optiune)
                {
                    case "M":
                        var masina = CitireMasinaTastatura();
                        adminMasini.AddMasina(masina);
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
                       var masina1 = new Masini(1, "Audi", "A4", "SV89ABC", 2017, 1986, (CuloareMasina)1, 
                           (CombustibilMasina)2, false);
                        Console.WriteLine(masina1);
                        var masina2 = new Masini(2, "Audi", "A4", "SV89XTC", 2017, 1986,
                            (CuloareMasina)3, (CombustibilMasina)3, false);
                        Console.WriteLine(masina2.ConversieLaSir());
                        if (masina1.Compare(masina2))
                            Console.WriteLine("Este aceiasi masina");
                        else
                            Console.WriteLine("Cele 2 masini sunt diferite");
                        Console.WriteLine("Introdu numar inmatriculare cautat: ");
                        string Nrinm = Console.ReadLine();
                        //Console.WriteLine(GetIdMasina(MasiniFisier, NrMasini, Nrinm).Model);
                        Console.ReadKey();
                        break;
                    case "F":
                        ArrayList masinii = adminMasini.GetMasini();
                        foreach(Masini m in masinii)
                            Console.WriteLine(m.ConversieLaSir());
                        Console.ReadKey();
                        break;
                    case "X":
                        Console.WriteLine(Utils.CNPValidate("1234567891234"));
                        Console.ReadKey();
                        System.Environment.Exit(1);
                        break;
                }
            } while (true);
        }
        public static Masini GetIdMasina(Masini[] masini, int NrMasini, string NrInm)
        {
            for (int i = 0; i < NrMasini; i++)
            {
                if (masini[i].NumarInmatriculare == NrInm)
                    return masini[i];
            }
            return null;
        }

        public static Masini CitireMasinaTastatura()
        {
            string mesaj;
            mesaj = "Brend, Model, Nr. Inmatriculare, An, Capacitate Motor, Culoare:\n1.Alb\n";
            mesaj += "2.Negru\n3.Albastru\n4.Verde\n5.Portocaliu\n6.Galben,";
            mesaj += "Motorizare:\n1.Benzina\n2.Diesel\n3.Electrica, Inghiriata: 0 Nu 1 Da";
            Console.WriteLine(mesaj);
            //var masina = new Masini(Console.ReadLine());
            var masina = new Masini(1, "Audi", "A4", "SV89ABC", 2017, 1986, (CuloareMasina)1, (CombustibilMasina)2, false);
            return masina;
        }
    }
}
