// Andronic Tudor - 3121A

using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;

namespace NivelAccesDate
{
    public class AdministrareMasini_FisierText : IStocareDataMasini
    {
        private const int ID_PRIMA_MASINA = 1;
        private const int INCREMENT = 1;
        private const char DELIMITER = ',';

        string NumeFisier { get; set; }
        public AdministrareMasini_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }
        public void AddMasina(Masini m)
        {
            m.IdMasina = GetId();
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                    swFisierText.WriteLine(m.ConversieLaSir(DELIMITER));
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public List<Masini> GetMasini()
        {
            List<Masini> masini = new List<Masini>(); 
            
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != "")
                        {
                            Masini m = new Masini(line);
                            masini.Add(m);
                        }
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return masini;
        }

        public Masini GetMasina(string NumarInmatriculare)
        {
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        Masini m = new Masini(line);
                        if (m.NumarInmatriculare == NumarInmatriculare)
                            return m;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

        public Masini GetMasinaByIndex(int index)
        {
            try
            {
                int contor = 0;
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == "")
                            continue;
                        Masini m = new Masini(line);
                        if (contor == index)
                            return m;
                        contor++;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

        public bool UpdateMasina(Masini MasinaActualizata)
        {
            List<Masini> masinii = GetMasini();
            bool actualizareCuSucces = false;
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Masini m in masinii)
                    {
                        if (m.IdMasina != MasinaActualizata.IdMasina)
                        {
                            swFisierText.WriteLine(m.ConversieLaSir(DELIMITER));
                        }
                        else
                        {
                            swFisierText.WriteLine(MasinaActualizata.ConversieLaSir(DELIMITER));
                        }
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;
        }

        private int GetId()
        {
            int IdMasina = ID_PRIMA_MASINA;
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Masini m = new Masini(line);
                        IdMasina = m.IdMasina + INCREMENT;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return IdMasina;
        }
    }
}
