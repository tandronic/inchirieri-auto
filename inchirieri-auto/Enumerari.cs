using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchirieri_auto
{
    public enum CuloareMasina
    {
        Alb = 1,
        Negru = 2,
        Albastru = 3,
        Verde = 4,
        Galben = 6,
        Portocaliu = 5
    };

    public enum OptiuniMasina
    {
        AerConditiona = 1,
        Clima = 2,
        CutieAutomata = 3,
        CutieManuala = 4,
        GeamuriElectrice = 5,
        Navigatie = 6,
        PilotAutomat = 7,
        Xenon = 8,
        ScauneIncalzite = 9
    };

    public enum CombustibilMasina
    {
        Benzina = 1,
        Diesel = 2,
        Electric = 3
    };
}
