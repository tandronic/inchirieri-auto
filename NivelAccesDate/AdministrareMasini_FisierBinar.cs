using System;
using System.Collections;
using LibrarieModele;

namespace NivelAccesDate
{
    //clasa AdministrareMasini_FisierBinar implementeaza interfata IStocareData
    public class AdministrareMasini_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareMasini_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddMasina(Masini m)
        {
            throw new Exception("Optiunea AddSMasini nu este implementata");
        }

        public ArrayList GetMasini()
        {
            throw new Exception("Optiunea GetMasini nu este implementata");
        }

        public Masini GetMasina(string VIN)
        {
            throw new Exception("Optiunea GetMasina nu este implementata");
        }

        public bool UpdateMasina(Masini m)
        {
            throw new Exception("Optiunea UpdateStudent nu este implementata");
        }
    }
}
