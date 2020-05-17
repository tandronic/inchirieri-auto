using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string functie { get; set; }
        public DateTime dataAngajati { get; set; }

        private int NR_ATRIBUTE = 8;

        public Angajati(int _id, string _nume, string _prenume, string _adresa, string _numar_telefon, 
            string _cnp, string _functie, DateTime _dataAngajari)
        {
            IdAngajat = _id;
            Nume = _nume;
            Prenume = _prenume;
            Adresa = _adresa;
            NumarTelefon = _numar_telefon;
            Cnp = _cnp;
            functie = _functie;
            dataAngajati = _dataAngajari;
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
                functie = date[6];
                dataAngajati = System.Convert.ToDateTime(date[7]);
            }
        }

        public string ConversieLaSir(char delimiter)
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}", 
               delimiter, IdAngajat, Data(delimiter), functie, dataAngajati);
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
