// Andronic Tudor - 3121A

using System;

namespace LibrarieModele
{
    public class Persoane
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Adresa { get; set; }
        public string NumarTelefon { get; set; }
        public string Cnp { get; set; }

        public string Data(char delimiter)
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}",
                delimiter, Nume, Prenume, Adresa, NumarTelefon, Cnp);
        }

        public bool Compare(Persoane persoana)
        {
            if (Cnp == persoana.Cnp)
                return true;
            return false;
        }
    }

    public class Angajati: Persoane
    {
        public int IdAngajat { get; set; }
        public Functie Functie { get; set; }
        public DateTime DataAngajare { get; set; }

        private int NR_ATRIBUTE = 8;

        public Angajati()
        {
            IdAngajat = 0;
            Nume = Prenume = Adresa = NumarTelefon = Cnp = string.Empty;
        }

        public Angajati(int _id, string _nume, string _prenume, string _adresa, string _numar_telefon, 
            string _cnp, Functie _functie, DateTime _dataAngajare)
        {
            IdAngajat = _id;
            Nume = _nume;
            Prenume = _prenume;
            Adresa = _adresa;
            NumarTelefon = _numar_telefon;
            Cnp = _cnp;
            Functie = _functie;
            DataAngajare = _dataAngajare;
        }

        public Angajati(string linie)
        {
            string[] date = linie.Split(',');
            if (date.Length == NR_ATRIBUTE)
            {
                IdAngajat = Utils.IntConvert(date[0]);
                Nume = date[1];
                Prenume = date[2];
                Adresa = date[3];
                NumarTelefon = date[4];
                if (Utils.CNPValidate(date[5]))
                    Cnp = date[5];
                else
                    Cnp = "";
                Functie = Utils.FunctieConvert(date[6]);
                DataAngajare = System.Convert.ToDateTime(date[7]);
            }
        }

        public string ConversieLaSir(char delimiter)
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}", 
               delimiter, IdAngajat, Data(delimiter), Functie, DataAngajare);
        }
    }

    public class Clienti: Persoane
    {
        public int IdClient { get; set; }
        public string NrMasinaInc { get; set; }
        
        public DateTime dataInchiriere { get; set; }

        public DateTime dataSfarsitInc { get; set; }

        private int NR_ATRIBUTE = 9;

        public Clienti()
        {
            IdClient = 0;
            Nume = Prenume = Adresa = NumarTelefon = Cnp = NrMasinaInc = string.Empty;
        }

        public Clienti(int _id, string _nume, string _prenume, string _adresa, string _numarTelefon,
            string _cnp, string _NrMasinaInc, DateTime _dataInchiriere, DateTime _dataSfarsitInc)
        {
            IdClient = _id;
            Nume = _nume;
            Prenume = _prenume;
            Adresa = _adresa;
            NumarTelefon = _numarTelefon;
            Cnp = _cnp;

            NrMasinaInc = _NrMasinaInc;
            dataInchiriere = _dataInchiriere;
            dataSfarsitInc = _dataSfarsitInc;
        }

        public Clienti(string linie)
        {
            string[] date = linie.Split(',');
            if(date.Length == NR_ATRIBUTE)
            {
                IdClient = Utils.IntConvert(date[0]);
                Nume = date[1];
                Prenume = date[2];
                Adresa = date[3];
                if (Utils.PhoneValidate(date[4]))
                    NumarTelefon = date[4];
                else
                    NumarTelefon = "";
                if (Utils.CNPValidate(date[5]))
                    Cnp = date[5];
                else
                    Cnp = "";
                NrMasinaInc = date[6];
                dataInchiriere = System.Convert.ToDateTime(date[7]);
                dataSfarsitInc = System.Convert.ToDateTime(date[8]);
            }
        }

        public string ConversieLaSir(char delimiter)
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}",
                delimiter, IdClient, Data(delimiter), NrMasinaInc, dataInchiriere, dataSfarsitInc);
        }
    }
}
