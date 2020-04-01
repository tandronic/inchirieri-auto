﻿using System;
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
            CombustibilMasina _combustibil, OptiuniMasina[] _optiuni, bool _inchiriata)
        {
            Brend = _brend;
            Model = _model;
            NumarInmatriculare = _numar;
            AnFabricatie = _an_fabricatie;
            CapacitateMotor = _capacitate_motor;
            Culoare = _culoare;
            Combustibil = _combustibil;
            Optiuni = _optiuni;
            Inchiriata = _inchiriata;
        }

        public string ConversieLaSir()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", 
                Brend, Model, NumarInmatriculare, AnFabricatie, CapacitateMotor, Culoare, Combustibil, Optiuni);
        }

        public bool Compare(Masini masina)
        {
            if (NumarInmatriculare == masina.NumarInmatriculare)
                return true;
            return false;
        }
    }
}
