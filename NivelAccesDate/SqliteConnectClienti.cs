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
    public class SqliteConnectClienti
    {
        public static List<Clienti> LoadClienti()
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Clienti>("select * from Client;", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveClient(Clienti c, int IdUser)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                cn.Execute("insert into Client (Nume, Prenume, Adresa, NumarTelefon, Cnp, IdUser) values " +
                    string.Format("({0},{1});", c.ConversieDB(), IdUser));
            }
        }

        public static void UpdateClient(Clienti c)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                string data = c.ConversieDB();
                cn.Execute(string.Format("update Client set Nume='{0}', Prenume='{1}', Adresa='{2}', NumarTelefon='{3}', " +
                    "Cnp='{4}' where IdClient={5};", c.Nume, c.Prenume, c.Adresa, c.NumarTelefon, c.Cnp,
                    c.IdClient));
            }
        }

        public static Clienti SearchClientByCnp(string Cnp)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Clienti>(string.Format("select * from Client where Cnp='{0}';", Cnp), new DynamicParameters());
                if(output.Count() != 0)
                    return output.ToList()[0];
            }
            return null;
        }

        public static Clienti SearchClientById(int Id)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Clienti>(string.Format("select * from Client where IdClient={0};", Id), new DynamicParameters());
                if (output.Count() != 0)
                    return output.ToList()[0];
            }
            return null;
        }

        public static Clienti SearchClientByUserId(int IdUser)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Clienti>(string.Format("select * from Client where IdUser={0};", IdUser), new DynamicParameters());
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
