// Andronic Tudor - 3121A

using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using LibrarieModele;


namespace NivelAccesDate
{
    public class SqliteConnectClientiMasini
    {
        public static DataTable LoadData()
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                cn.Open();
                SQLiteDataAdapter DataAdapter = new SQLiteDataAdapter("SELECT m.Brend, m.Model, m.NumarInmatriculare, m.AnFabricatie, m.CapacitateMotor, m.Culoare, " +
                    "m.OptiuniString, cm.dataInchiriere, cm.dataSfInchiriere from Masina m inner join ClientMasina cm on cm.IdMasina = m.IdMasina", cn);
                cn.Close();
                DataTable Data = new DataTable();
                DataAdapter.Fill(Data);
                return Data;
            }
        }

        public static DataTable LoadDataForCustomer(int IdUser)
        {
            int IdClient = SqliteConnectClienti.SearchClientByUserId(IdUser).IdClient;
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                cn.Open();
                SQLiteDataAdapter DataAdapter = new SQLiteDataAdapter("SELECT m.Brend, m.Model, m.NumarInmatriculare, m.AnFabricatie, m.CapacitateMotor, m.Culoare, " +
                    string.Format("m.OptiuniString, cm.dataInchiriere, cm.dataSfInchiriere from Masina m inner join ClientMasina cm on cm.IdMasina = m.IdMasina where cm.Idclient={0}", IdClient), cn);
                cn.Close();
                DataTable Data = new DataTable();
                DataAdapter.Fill(Data);
                return Data;
            }
        }

        public static void SaveData(int IdUser, int IdMasina, string dataInchiriere, string dataSfInchiriere)
        {
            int IdClient = SqliteConnectClienti.SearchClientByUserId(IdUser).IdClient;
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                cn.Execute(string.Format("insert into ClientMasina (IdClient, IdMasina, dataInchiriere, dataSfInchiriere) values ({0},{1},'{2}','{3}');",
                    IdClient, IdMasina, dataInchiriere, dataSfInchiriere));
            }
        }

        public static Masini SearchByClientId(int IdClient)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Masini>(string.Format("select * from Masina where NumarInmatriculare='{0}';", IdClient), new DynamicParameters());
                if(output.Count() != 0)
                {
                    foreach (Masini m in output)
                    {
                        m.Optiuni = new List<string>();
                        string[] OptiuniSelectate = m.OptiuniString.Split(';');
                        foreach (string optiune in OptiuniSelectate)
                            m.Optiuni.Add(optiune);
                    }
                    return output.ToList()[0];
                }
            }
            return null;
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
