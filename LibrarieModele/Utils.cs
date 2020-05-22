using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LibrarieModele
{
    public class Utils
    {
        public static int ERROR_CONVERT = -1;
        public static int IntConvert(string value)
        {
            int int_value;
            if (System.Int32.TryParse(value, out int_value))
                return int_value;
            return ERROR_CONVERT;
        }

        public static CuloareMasina CuloareConvert(string value)
        {
            CuloareMasina culoare;
            if (Enum.TryParse(value, true, out culoare))
                return culoare;
            return CuloareMasina.CuloareInexistenta;
        }

        public static bool CuloareValidate(string value)
        {
            CuloareMasina culoare;
            if (Enum.TryParse(value, true, out culoare))
                return true;
            return false;
        }

        public static CombustibilMasina CombustibilConvert(string value)
        {
            CombustibilMasina combustibil;
            if (Enum.TryParse(value, true, out combustibil))
                return combustibil;
            return CombustibilMasina.CombustibilInvalid;
        }

        public static OptiuniMasina OptiuniConvert(string value)
        {
            OptiuniMasina optiune;
            if (Enum.TryParse(value, true, out optiune))
                return optiune;
            return OptiuniMasina.OptiuneInexistenta;
        }

        public static bool CombustibilValidate(string value)
        {
            CombustibilMasina combustibil;
            if (Enum.TryParse(value, true, out combustibil))
                return true;
            return false;
        }

        public static bool CNPValidate(string value)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (value.Length == 13 && regex.IsMatch(value))
                return true;
            return false;
        }

        public static bool PhoneValidate(string value)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (value.Length == 10 && regex.IsMatch(value))
                return true;
            return false;
        }

        public static bool InchiriataToBoolConvert(string value)
        {
            if (value.Equals("Da"))
                return true;
            return false;
        }

        public static string BoolToInchiriataConvert(bool value)
        {
            if (value)
                return "Da";
            return "Nu";
        }

        public static bool InchiriataValidate(string value)
        {
            if (value.ToUpper().Equals("DA") || value.ToUpper().Equals("NU"))
                return true;
            return false;
        }

        public static Functie FunctieConvert(string value)
        {
            Functie functie;
            if (Enum.TryParse(value, true, out functie))
                return functie;
            return Functie.FunctieInvalid;
        }
    }
}