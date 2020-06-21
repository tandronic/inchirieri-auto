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
    public class SqliteConnectAngajati
    {
        public static List<Angajati> LoadAngajati()
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Angajati>("select * from Angajat;", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveAngajat(Angajati a)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                cn.Execute("insert into Angajat (Nume, Prenume, Adresa, NumarTelefon, Cnp, Functie, DataAngajare) values " +
                    a.ConversieDB() + ';');
            }
        }

        public static void UpdateAngajat(Angajati a)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                cn.Execute(string.Format("update Angajat set Nume='{0}', Prenume='{1}', Adresa='{2}', NumarTelefon='{3}', " +
                    "Cnp='{4}', Functie='{5}', DataAngajare='{6}' where IdAngajat={7};", a.Nume, a.Prenume, a.Adresa, a.NumarTelefon, a.Cnp,
                    a.Functie, a.DataAngajare, a.IdAngajat));
            }
        }

        public static Angajati SearchAngajatByCnp(string Cnp)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Angajati>(string.Format("select * from Angajat where Cnp='{0}';", Cnp), new DynamicParameters());
                if (output.Count() != 0)
                    return output.ToList()[0];
            }
            return null;
        }

        public static Angajati SearchAngajatById(int Id)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Angajati>(string.Format("select * from Angajat where IdAngajat={0};", Id), new DynamicParameters());
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
