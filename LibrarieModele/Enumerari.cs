// Andronic Tudor - 3121A

namespace LibrarieModele
{
    public enum CuloareMasina
    {
        CuloareInexistenta = 0,
        Alb = 1,
        Negru = 2,
        Albastru = 3,
        Verde = 4,
        Galben = 6,
        Portocaliu = 5
    };

    public enum OptiuniMasina
    {
        OptiuneInexistenta = 0,
        AerConditionat = 1,
        Clima = 2,
        CutieAutomata = 3,
        IncalzireInScaune = 4,
        GeamuriElectrice = 5,
        Navigatie = 6,
        PilotAutomat = 7,
        Xenon = 8
    };

    public enum CombustibilMasina
    {
        CombustibilInvalid = 0,
        Benzina = 1,
        Diesel = 2,
        Electric = 3
    };

    public enum Functie
    {
        FunctieInvalid = 0,
        Director = 1,
        Marketing = 2,
        Mecanic = 3,
        FemeieServiciu = 4
    };

    public enum UserType
    {
        UserInvalid = 0,
        Client = 1,
        Angajat = 2,
        Admin = 3
    }
}
