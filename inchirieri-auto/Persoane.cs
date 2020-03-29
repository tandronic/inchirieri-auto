using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchirieri_auto
{
    class Persoane
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
    }

    class Angajati: Persoane
    {
        public string functie { get; set; }
        public int ziua_ang { get; set; } 
        public int luna_ang { get; set; }
        public int anul_ang { get; set; }

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


        public string ConversieLaSir()
        {
            return string.Format("{0}, {1}, {2}, {3}", 
                Data(), functie, ziua_ang, luna_ang, anul_ang);
        }
    }

    class Clienti: Persoane
    {
        public string NrMasinaInc { get; set; }
        public int ZiuaInc { get; set; }
        public int LunaInc { get; set; } 
        public int AnulInc { get; set; }
        public int PerioadaInc { get; set; }

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

        public string ConversieLaSir()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}",
                Data(), NrMasinaInc, ZiuaInc, LunaInc, AnulInc, PerioadaInc);
        }
    }
}
