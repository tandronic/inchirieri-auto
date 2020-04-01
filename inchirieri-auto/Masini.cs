using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchirieri_auto
{
    class Masini
    {
        public string Brend { get; set; }
        public string Model { get; set; }
        public string NumarInmatriculare { get; set; }
        public int AnFabricatie { get; set; }
        public int CapacitateMotor { get; set; }
        public bool Inchiriata { get; set; }

        public CuloareMasina Culoare { get; set; }
        public CombustibilMasina Combustibil { get; set; }
        public OptiuniMasina[] Optiuni;

        public Masini()
        {
            Brend = Model = NumarInmatriculare = string.Empty;
            AnFabricatie = CapacitateMotor = 0;
            Inchiriata = false;
        }

        public Masini(string _brend, string _model, string _numar, 
            int _an_fabricatie, int _capacitate_motor, CuloareMasina _culoare, 
            CombustibilMasina _combustibil, bool _inchiriata)
        {
            Brend = _brend;
            Model = _model;
            NumarInmatriculare = _numar;
            AnFabricatie = _an_fabricatie;
            CapacitateMotor = _capacitate_motor;
            Culoare = _culoare;
            Combustibil = _combustibil;
            //Optiuni = _optiuni;
            Inchiriata = _inchiriata;
        }

        public Masini(string linie)
        {
            string[] date = linie.Split(',');
            Brend = date[0];
            Model = date[1];
            NumarInmatriculare = date[2];
            AnFabricatie = System.Convert.ToInt32(date[3]);
            CapacitateMotor = System.Convert.ToInt32(date[4]);
            Culoare = (CuloareMasina)Enum.Parse(typeof(CuloareMasina), date[5]);
            Combustibil = (CombustibilMasina)Enum.Parse(typeof(CombustibilMasina), date[6]);
            //Optiuni = _optiuni;
        }

        public string ConversieLaSir()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}\n", 
                Brend, Model, NumarInmatriculare, AnFabricatie, CapacitateMotor, Culoare, Combustibil);
        }

        public string ConversieLaSirFisier()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
                Brend, Model, NumarInmatriculare, AnFabricatie, CapacitateMotor, Culoare, Combustibil);
        }

        public bool Compare(Masini masina)
        {
            if (NumarInmatriculare == masina.NumarInmatriculare)
                return true;
            return false;
        }
    }
}
