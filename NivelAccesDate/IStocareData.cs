using LibrarieModele;
using System.Collections;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddMasina(Masini m);
        ArrayList GetMasini();

        Masini GetMasina(string NumarInmatriculare);

        bool UpdateMasina(Masini m);
    }
}
