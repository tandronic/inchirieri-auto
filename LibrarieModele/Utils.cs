// Andronic Tudor - 3121A

using System;
using System.Text.RegularExpressions;

namespace LibrarieModele
{
    public class Utils
    {
        public static int ERROR_CONVERT = -1;
        public static int CNP_LEN = 13;
        public static int PHONE_LEN = 10;
        public static int IntConvert(string value)
        {
            // Convert a string to int
            int int_value;
            if (System.Int32.TryParse(value, out int_value))
                return int_value;
            return ERROR_CONVERT;
        }

        public static CuloareMasina CuloareConvert(string value)
        {
            // Convert a string to a enum element
            CuloareMasina culoare;
            if (Enum.TryParse(value, true, out culoare))
                return culoare;
            return CuloareMasina.CuloareInexistenta;
        }

        public static bool CuloareValidate(string value)
        {
            // Check if a string is a enum element
            CuloareMasina culoare;
            if (Enum.TryParse(value, true, out culoare))
                return true;
            return false;
        }

        public static CombustibilMasina CombustibilConvert(string value)
        {
            // Convert a string to a enum element
            CombustibilMasina combustibil;
            if (Enum.TryParse(value, true, out combustibil))
                return combustibil;
            return CombustibilMasina.CombustibilInvalid;
        }

        public static OptiuniMasina OptiuniConvert(string value)
        {
            // Convert a string to a enum element
            OptiuniMasina optiune;
            if (Enum.TryParse(value, true, out optiune))
                return optiune;
            return OptiuniMasina.OptiuneInexistenta;
        }

        public static bool CombustibilValidate(string value)
        {
            // Check if a string is a enum element
            CombustibilMasina combustibil;
            if (Enum.TryParse(value, true, out combustibil))
                return true;
            return false;
        }

        public static bool CNPValidate(string value)
        {
            // Check if a string is a CNP
            Regex regex = new Regex("^[0-9]+$");
            // Check if the string contains only numbers and has 13 characters
            if (value.Length == CNP_LEN && regex.IsMatch(value))
                return true;
            return false;
        }

        public static bool PhoneValidate(string value)
        {
            // Check if a string is a phone number
            Regex regex = new Regex("^[0-9]+$");
            // Check if the string contains only numbers and has 10 characters
            if (value.Length == PHONE_LEN && regex.IsMatch(value))
                return true;
            return false;
        }

        public static bool InchiriataToBoolConvert(string value)
        {
            // Convert string to bool
            if (value.ToUpper().Equals("DA"))
                return true;
            return false;
        }

        public static string BoolToInchiriataConvert(bool value)
        {
            // Convert bool to string
            if (value)
                return "Da";
            return "Nu";
        }

        public static bool InchiriataValidate(string value)
        {
            // Check if a string can be convert to a bool
            if (value.ToUpper().Equals("DA") || value.ToUpper().Equals("NU"))
                return true;
            return false;
        }

        public static Functie FunctieConvert(string value)
        {
            // Convert a string to a enum element
            Functie functie;
            if (Enum.TryParse(value, true, out functie))
                return functie;
            return Functie.FunctieInvalid;
        }

        public static bool PasswordValidate(string value)
        {
            Regex regex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,15}");
            if (regex.IsMatch(value))
                return true;
            return false;
        }
    }
}