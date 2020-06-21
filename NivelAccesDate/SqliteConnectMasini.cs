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
    public class SqliteConnectMasini
    {
        public static List<Masini> LoadMasini()
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Masini>("select * from Masina;", new DynamicParameters());
                foreach(Masini m in output)
                {
                    m.Optiuni = new List<string>();
                    string[] OptiuniSelectate = m.OptiuniString.Split(';');
                    foreach (string optiune in OptiuniSelectate)
                        m.Optiuni.Add(optiune);
                }
                return output.ToList();
            }
        }

        public static void SaveMasina(Masini masina)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                cn.Execute("insert into Masina (Brend, Model, NumarInmatriculare, AnFabricatie, CapacitateMotor, Culoare, Combustibil, OptiuniString, Inchiriata, dataActualizare) values " +
                    masina.ConversieLaDB());
            }
        }

        public static void UpdateMasina(Masini masina)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                string data = masina.ConversieLaDB();
                cn.Execute(string.Format("update Masina set Brend='{0}', Model='{1}', NumarInmatriculare='{2}', AnFabricatie='{3}', " +
                    "CapacitateMotor='{4}', Culoare='{5}', Combustibil='{6}', OptiuniString='{7}', Inchiriata='{8}', dataActualizare='{9}' where IdMasina={10}", masina.Brend, masina.Model,
                    masina.NumarInmatriculare, masina.AnFabricatie, masina.CapacitateMotor, masina.Culoare, masina.Combustibil, masina.OptiuniToString, 
                    masina.Inchiriata, masina.dataActualizare.ToString(), masina.IdMasina));
            }
        }

        public static Masini SearchMasinaByNr(string NrInamt)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Masini>(string.Format("select * from Masina where NumarInmatriculare='{0}';", NrInamt), new DynamicParameters());
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

        public static Masini SearchMasinaById(int Id)
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Masini>(string.Format("select * from Masina where IdMasina={0};", Id), new DynamicParameters());
                if (output.Count() != 0)
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

        public static List<Masini> GetMasiniDisponibile()
        {
            using (SQLiteConnection cn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cn.Query<Masini>("select * from Masina where Inchiriata='False';", new DynamicParameters());
                foreach (Masini m in output)
                {
                    m.Optiuni = new List<string>();
                    string[] OptiuniSelectate = m.OptiuniString.Split(';');
                    foreach (string optiune in OptiuniSelectate)
                        m.Optiuni.Add(optiune);
                }
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
