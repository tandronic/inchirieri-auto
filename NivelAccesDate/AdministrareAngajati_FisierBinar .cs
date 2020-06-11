// Andronic Tudor - 3121A

using System;
using System.Collections.Generic;
using LibrarieModele;

namespace NivelAccesDate
{
    public class AdministrareAngajati_FisierBinar : IStocareDataAngajati
    {
        string NumeFisier { get; set; }
        public AdministrareAngajati_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddAngajat(Angajati a)
        {
            throw new Exception("Optiunea AddAngajat este implementata");
        }

        public List<Angajati> GetAngajati()
        {
            throw new Exception("Optiunea GetAngajati nu este implementata");
        }

        public Angajati GetAngajat(string CNP)
        {
            throw new Exception("Optiunea GetAngajati nu este implementata");
        }

        public Angajati GetAngajatByIndex(int index)
        {
            throw new Exception("Optiunea GetAngajatiByIndex nu este implementata");
        }

        public bool UpdateAngajat(Angajati AngajatActualizat)
        {
            throw new Exception("Optiunea UpdateAngajati nu este implementata");
        }
    }
}
