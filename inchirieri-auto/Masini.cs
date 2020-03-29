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
        public bool Inchiriata {get; set;}

        public Masini()
        {
            Brend = Model = NumarInmatriculare = string.Empty;
            AnFabricatie = CapacitateMotor = 0;
            Inchiriata = false;
        }

        public Masini(string _brend, string _model, string _numar, 
            int _an_fabricatie, int _capacitate_motor, bool _inchiriata)
        {
            Brend = _brend;
            Model = _model;
            NumarInmatriculare = _numar;
            AnFabricatie = _an_fabricatie;
            CapacitateMotor = _capacitate_motor;
            Inchiriata = _inchiriata;
        }

        public string ConversieLaSir()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", 
                Brend, Model, NumarInmatriculare, AnFabricatie, CapacitateMotor);
        }
    }
}
