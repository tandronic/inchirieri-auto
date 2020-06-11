// Andronic Tudor - 3121A

using System;
using System.Collections.Generic;
using LibrarieModele;

namespace NivelAccesDate
{
    public class AdministrareMasini_FisierBinar : IStocareDataMasini
    {
        string NumeFisier { get; set; }
        public AdministrareMasini_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddMasina(Masini m)
        {
            throw new Exception("Optiunea AddMasini nu este implementata");
        }

        public List<Masini> GetMasini()
        {
            throw new Exception("Optiunea GetMasini nu este implementata");
        }

        public Masini GetMasina(string VIN)
        {
            throw new Exception("Optiunea GetMasina nu este implementata");
        }

        public Masini GetMasinaByIndex(int index)
        {
            throw new Exception("Optiunea GetMasina nu este implementata");
        }

        public bool UpdateMasina(Masini m)
        {
            throw new Exception("Optiunea UpdateStudent nu este implementata");
        }
    }
}
