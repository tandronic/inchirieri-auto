using LibrarieModele;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
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
}
