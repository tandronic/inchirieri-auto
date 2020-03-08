using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchirieri_auto
{
    class Masini
    {
        string brend, model, vin;
        int an_fabricatie, capacitate_motor;
        bool inchiriata;

        public Masini()
        {
            brend = model = vin = string.Empty;
            an_fabricatie = capacitate_motor = 0;
            inchiriata = false;
        }

        public Masini(string _brend, string _model, string _vin, 
            int _an_fabricatie, int _capacitate_motor, bool _inchiriata)
        {
            brend = _brend;
            model = _model;
            vin = _vin;
            an_fabricatie = _an_fabricatie;
            capacitate_motor = _capacitate_motor;
            inchiriata = _inchiriata;
        }

        public int get_an_fabricatie()
        {
            return an_fabricatie;
        }

        public bool get_inchiriata()
        {
            return inchiriata;
        }

        public string Info()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", 
                brend, model, vin, an_fabricatie, capacitate_motor);
        }
    }
}
