using NivelAccesDate;
using System.Configuration;

namespace inchirieri_auto_form
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER_MASINI = "NumeFisierMasini";
        private const string NUME_FISIER_CLIENTI = "NumeFisierClienti";
        private const string NUME_FISIER_ANGAJATI = "NumeFisierAngajati";
        public static IStocareDataMasini GetAdministratorStocareMasini()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierMasini = ConfigurationManager.AppSettings[NUME_FISIER_MASINI];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareMasini_FisierBinar(numeFisierMasini + "." + formatSalvare);
                    case "txt":
                        return new AdministrareMasini_FisierText(numeFisierMasini + "." + formatSalvare);
                }
            }
            return null;
        }
        public static IStocareDataClienti GetAdministratorStocareClienti()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierClienti = ConfigurationManager.AppSettings[NUME_FISIER_CLIENTI];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareClienti_FisierBinar(numeFisierClienti + "." + formatSalvare);
                    case "txt":
                        return new AdministrareClienti_FisierText(numeFisierClienti + "." + formatSalvare);
                }
            }
            return null;
        }
        public static IStocareDataAngajati GetAdministratorStocareAngajati()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierAngajati = ConfigurationManager.AppSettings[NUME_FISIER_ANGAJATI];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareAngajati_FisierBinar(numeFisierAngajati + "." + formatSalvare);
                    case "txt":
                        return new AdministrareAngajati_FisierText(numeFisierAngajati + "." + formatSalvare);
                }
            }
            return null;
        }
    }
}
