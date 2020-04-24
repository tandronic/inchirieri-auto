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
        public static CuloareMasina CULOARE_DEFAULT = CuloareMasina.Alb;
        public static CombustibilMasina COMBUSTIBIL_DEFAULT = CombustibilMasina.Diesel;
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
            return CULOARE_DEFAULT;
        }

        public static CombustibilMasina CombustibilConvert(string value)
        {
            CombustibilMasina combustibil;
            if (Enum.TryParse(value, true, out combustibil))
                return combustibil;
            return COMBUSTIBIL_DEFAULT;
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
            if (value.Length == 11 && regex.IsMatch(value))
                return true;
            return false;
        }
    }
}
