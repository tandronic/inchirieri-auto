// Andronic Tudor - 3121A

using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using LibrarieModele;

namespace NivelAccesDate
{
    public class SqliteConnectUseri
    {
        public static List<Useri> LoadUseri()
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Useri>("select * from User;", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveUser(Useri u)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var data = u.ConversieDB();
                cn.Execute("insert into User (Username, Password, Type, dataActualizare) values " +
                    u.ConversieDB() + ';');
            }
        }

        public static Useri Login(string username, string password)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Useri>(string.Format("select * from User where Username='{0}' and Password='{1}';", username, password), 
                    new DynamicParameters());
                if (output.Count() != 0)
                    return output.ToList()[0];
            }
            return null;
        }

        public static void UpdateUser(Useri u)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                cn.Execute(string.Format("update User set Username='{0}', Password='{1}', dataActualizare='{2}' where IdUser={3};", 
                    u.Username, u.Password, u.dataActualizare, u.IdUser));
            }
        }

        public static Useri SearchUser(string username)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Useri>(string.Format("select * from User where Username='{0}';", username), new DynamicParameters());
                if (output.Count() != 0)
                    return output.ToList()[0];
            }
            return null;
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
