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
        public int Varsta { get; set; }

        public string Data()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}",
                Nume, Prenume, Adresa, NumarTelefon, Cnp, Varsta);
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
        public int ziua_ang { get; set; } 
        public int luna_ang { get; set; }
        public int anul_ang { get; set; }

        private int NR_ATRIBUTE = 10;

        public Angajati(string _nume, string _prenume, string _adresa, string _numar_telefon, 
            int _varsta, string _cnp, string _functie, int _ziua_ang, int _luna_ang, int _anul_ang)
        {
            Nume = _nume;
            Prenume = _prenume;
            Adresa = _adresa;
            NumarTelefon = _numar_telefon;
            Varsta = _varsta;
            Cnp = _cnp;

            functie = _functie;
            ziua_ang = _ziua_ang;
            luna_ang = _luna_ang;
            anul_ang = _anul_ang;
        }

        public Angajati(string linie)
        {
            string[] date = linie.Split(',');
            if (date.Length == NR_ATRIBUTE)
            {
                Nume = date[0];
                Prenume = date[1];
                Adresa = date[2];
                NumarTelefon = date[3];
                Varsta = Utils.IntConvert(date[4]);
                if (Utils.CNPValidate(date[4]))
                    Cnp = date[4];
                else
                    Cnp = "";
            }
        }

        public string ConversieLaSir()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", 
               IdAngajat, Data(), functie, ziua_ang, luna_ang, anul_ang);
        }
    }

    public class Clienti: Persoane
    {
        public int IdClient { get; set; }
        public string NrMasinaInc { get; set; }
        public int ZiuaInc { get; set; }
        public int LunaInc { get; set; } 
        public int AnulInc { get; set; }
        public int PerioadaInc { get; set; }

        private int NR_ATRIBUTE = 11;

        public Clienti(string _nume, string _prenume, string _adresa, string _numar_telefon,
            int _varsta, string _cnp, string _nr_masina_inc, int _ziua_inc, int _luna_inc, 
            int _anul_inc, int _perioada_inc)
        {
            Nume = _nume;
            Prenume = _prenume;
            Adresa = _adresa;
            NumarTelefon = _numar_telefon;
            Varsta = _varsta;
            Cnp = _cnp;

            NrMasinaInc = _nr_masina_inc;
            ZiuaInc = _ziua_inc;
            LunaInc = _luna_inc;
            AnulInc = _anul_inc;
            PerioadaInc = _perioada_inc;
        }

        public Clienti(string linie)
        {
            string[] date = linie.Split(',');
            if(date.Length == NR_ATRIBUTE)
            {
                Nume = date[0];
                Prenume = date[1];
                Adresa = date[2];
                if (Utils.PhoneValidate(date[3]))
                    NumarTelefon = date[3];
                else
                    NumarTelefon = "";
                Varsta = Utils.IntConvert(date[4]);
                if (Utils.CNPValidate(date[5]))
                    Cnp = date[5];
                else
                    Cnp = "";
                NrMasinaInc = date[6];
                ZiuaInc = Utils.IntConvert(date[7]);
                LunaInc = Utils.IntConvert(date[8]);
                AnulInc = Utils.IntConvert(date[9]);
                PerioadaInc = Utils.IntConvert(date[10]);
            }
        }

        public string ConversieLaSir()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}",
                IdClient, Data(), NrMasinaInc, ZiuaInc, LunaInc, AnulInc, PerioadaInc);
        }
    }
}
