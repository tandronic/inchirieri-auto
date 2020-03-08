using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchirieri_auto
{
    class Persoane
    {
        string nume, prenume, adresa, numar_telefon, cnp;
        int varsta;

        public string get_nume()
        {
            return nume;
        }

        public void set_nume(string _nume)
        {
            nume = _nume;
        }

        public string get_prenume()
        {
            return prenume;
        }

        public void set_prenume(string _prenume)
        {
            prenume = _prenume;
        }

        public string get_adresa()
        {
            return adresa;
        }

        public void set_adresa(string _adresa)
        {
            adresa = _adresa;
        }

        public string get_numar_telefon()
        {
            return numar_telefon;
        }

        public void set_numar_telefon(string _numar_telefon)
        {
            numar_telefon = _numar_telefon;
        }
        public int get_varsta()
        {
            return varsta;
        }

        public void set_varsta(int _varsta)
        {
            varsta = _varsta;
        }

        public string get_cnp()
        {
            return cnp;
        }

        public void set_cnp(string _cnp)
        {
            cnp = _cnp;
        }

        public string Data()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}",
                get_nume(), get_prenume(), get_adresa(), get_numar_telefon(),
                get_cnp(), get_varsta());
        }
    }

    class Angajati: Persoane
    {
        string functie;
        int ziua_ang, luna_ang, anul_ang;

        public Angajati(string _nume, string _prenume, string _adresa, string _numar_telefon, 
            int _varsta, string _cnp, string _functie, int _ziua_ang, int _luna_ang, int _anul_ang)
        {
            set_nume(_nume);
            set_prenume(_prenume);
            set_adresa(_adresa);
            set_numar_telefon(_numar_telefon);
            set_varsta(_varsta);
            set_cnp(_cnp);

            functie = _functie;
            ziua_ang = _ziua_ang;
            luna_ang = _luna_ang;
            anul_ang = _anul_ang;
        }

        public string get_functie()
        {
            return functie;
        }

        public int get_ziua_ang()
        {
            return ziua_ang;
        }

        public int get_luna_ang()
        {
            return luna_ang;
        }

        public int get_anul_ang()
        {
            return anul_ang;
        }

        public string Info()
        {
            return string.Format("{0}, {1}, {2}, {3}", 
                Data(), functie, ziua_ang, luna_ang, anul_ang);
        }
    }

    class Clienti: Persoane
    {
        string vin_masina_inc;
        int ziua_inc, luna_inc, anul_inc, perioada_inc;

        public Clienti(string _nume, string _prenume, string _adresa, string _numar_telefon,
            int _varsta, string _cnp, string _vin_masina_inc, int _ziua_inc, int _luna_inc, 
            int _anul_inc, int _perioada_inc)
        {
            set_nume(_nume);
            set_prenume(_prenume);
            set_adresa(_adresa);
            set_numar_telefon(_numar_telefon);
            set_varsta(_varsta);
            set_cnp(_cnp);

            vin_masina_inc = _vin_masina_inc;
            ziua_inc = _ziua_inc;
            luna_inc = _luna_inc;
            anul_inc = _anul_inc;
            perioada_inc = _perioada_inc;
        }

        public string get_vin_masina_inc()
        {
            return vin_masina_inc;
        }

        public int get_ziua_inc()
        {
            return ziua_inc;
        }

        public int get_luna_inc()
        {
            return luna_inc;
        }

        public int get_anul_inc()
        {
            return anul_inc;
        }

        public int get_perioada_inc()
        {
            return perioada_inc;
        }

        public string Info()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}",
                Data(), vin_masina_inc, ziua_inc, luna_inc, anul_inc, perioada_inc);
        }
    }
}
