using System;
using System.Collections.Generic;
using LibrarieModele;

namespace NivelAccesDate
{
    //clasa AdministrareMasini_FisierBinar implementeaza interfata IStocareData
    public class AdministrareClienti_FisierBinar : IStocareDataClienti
    {
        string NumeFisier { get; set; }
        public AdministrareClienti_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddClient(Clienti c)
        {
            throw new Exception("Optiunea AddClient este implementata");
        }

        public List<Clienti> GetClienti()
        {
            throw new Exception("Optiunea GetClienti nu este implementata");
        }

        public Clienti GetClient(string CNP)
        {
            throw new Exception("Optiunea GetClient nu este implementata");
        }

        public Clienti GetClientByIndex(int index)
        {
            throw new Exception("Optiunea GetClientByIndex nu este implementata");
        }

        public bool UpdateClient(Clienti ClientActualizat)
        {
            throw new Exception("Optiunea UpdateClient nu este implementata");
        }
    }
}
