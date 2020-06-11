// Andronic Tudor - 3121A

using LibrarieModele;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareDataMasini
    {
        void AddMasina(Masini m);
        List<Masini> GetMasini();

        Masini GetMasina(string NumarInmatriculare);
        Masini GetMasinaByIndex(int index);

        bool UpdateMasina(Masini m);
    }

    public interface IStocareDataClienti
    {
        void AddClient(Clienti c);
        List<Clienti> GetClienti();

        Clienti GetClient(string CNP);
        Clienti GetClientByIndex(int index);

        bool UpdateClient(Clienti ClientActualizat);
    }

    public interface IStocareDataAngajati
    {
        void AddAngajat(Angajati a);
        List<Angajati> GetAngajati();

        Angajati GetAngajat(string CNP);
        Angajati GetAngajatByIndex(int index);

        bool UpdateAngajat(Angajati AngajatActualizat);
    }
}
