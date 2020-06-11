// Andronic Tudor - 3121A

using System;
using System.Collections.Generic;

namespace LibrarieModele
{
    public class Masini
    {
        private char SEPARATOR_SECUNDAR_OPTIUNI_FISIER = ';';
        private const char SEPARATOR_AFISARE = ' ';

        public int IdMasina { get; set; }
        public string Brend { get; set; }
        public string Model { get; set; }
        public string NumarInmatriculare { get; set; }
        public int AnFabricatie { get; set; }
        public int CapacitateMotor { get; set; }
        public bool Inchiriata { get; set; }
        public DateTime dataActualizare { get; set; }

        private int _vechime;
        private int AN_CURENT = 2020;

        public int Vechime 
        {
            get
            {
                return _vechime;
            }
            set
            {
                _vechime = AN_CURENT - AnFabricatie;
            }
        }
        

        private int NR_ATRIBUTE = 11;

        public CuloareMasina Culoare { get; set; }
        public CombustibilMasina Combustibil { get; set; }
        public List<string> Optiuni { get; set; }

        public string OptiuniToString
        {
            // Convert a list of string items to a string
            get
            {
                string sOptiuni = string.Empty;

                foreach (string optiune in Optiuni)
                {
                    if (sOptiuni != string.Empty)
                    {
                        sOptiuni += SEPARATOR_SECUNDAR_OPTIUNI_FISIER;
                    }
                    sOptiuni += optiune;
                }

                return sOptiuni;
            }
        }

        public Masini()
        {
            Brend = Model = NumarInmatriculare = string.Empty;
            AnFabricatie = CapacitateMotor = Vechime = 0;
            Inchiriata = false;
        }

        public Masini(int _id, string _brend, string _model, string _numar,
            int _an_fabricatie, int _capacitate_motor, CuloareMasina _culoare,
            CombustibilMasina _combustibil, List<string> _optiuni, bool _inchiriata)
        {
            IdMasina = _id;
            Brend = _brend;
            Model = _model;
            NumarInmatriculare = _numar;
            AnFabricatie = _an_fabricatie;
            Vechime = _an_fabricatie;
            CapacitateMotor = _capacitate_motor;
            Culoare = _culoare;
            Combustibil = _combustibil;
            Optiuni = _optiuni;
            Inchiriata = _inchiriata;
        }

        public Masini(string linie)
        {
            string[] date = linie.Split(',');
            // Check if string has all data for a car
            if(date.Length == NR_ATRIBUTE)
            {
                IdMasina = Utils.IntConvert(date[0]);
                Brend = date[1];
                Model = date[2];
                NumarInmatriculare = date[3];
                AnFabricatie = Utils.IntConvert(date[4]);
                Vechime = Utils.IntConvert(date[4]);
                CapacitateMotor = Utils.IntConvert(date[5]);
                Culoare = Utils.CuloareConvert(date[6]);
                Combustibil = Utils.CombustibilConvert(date[7]);
                string[] optiuni = date[8].Split(SEPARATOR_SECUNDAR_OPTIUNI_FISIER);
                Optiuni = new List<string>();
                foreach (string optiune in optiuni)
                    Optiuni.Add(optiune);
                Inchiriata = Utils.InchiriataToBoolConvert(date[9]);
                dataActualizare = System.Convert.ToDateTime(date[10]);
            }
            
        }

        public string ConversieLaSir(char separator)
        {
            char old_separator = SEPARATOR_SECUNDAR_OPTIUNI_FISIER;
            if(separator == SEPARATOR_AFISARE)
                SEPARATOR_SECUNDAR_OPTIUNI_FISIER = separator;
            string response = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}",
                separator, IdMasina, Brend, Model, NumarInmatriculare, AnFabricatie, CapacitateMotor, 
                Culoare, Combustibil, OptiuniToString, Utils.BoolToInchiriataConvert(Inchiriata), dataActualizare);
            SEPARATOR_SECUNDAR_OPTIUNI_FISIER = old_separator;
            return response;
        }

        public bool Compare(Masini masina)
        {
            if (NumarInmatriculare == masina.NumarInmatriculare)
                return true;
            return false;
        }
    }
}
