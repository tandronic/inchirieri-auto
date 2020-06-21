// Andronic Tudor - 3121A

using System;

namespace LibrarieModele
{
    public class Useri
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
        public DateTime dataActualizare { get; set; }

        public string Data(char delimiter)
        {
            return string.Format("{1}{0}{2}{0}{3}",
                delimiter, Username, Password, Type);
        }

        public string ConversieDB()
        {
            return string.Format("('{1}'{0}'{2}'{0}'{3}'{0}'{4}')",
                ',', Username, Password, Type, dataActualizare);
        }
    }
}
