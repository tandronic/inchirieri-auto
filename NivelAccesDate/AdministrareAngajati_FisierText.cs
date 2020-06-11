// Andronic Tudor - 3121A

using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;

namespace NivelAccesDate
{
    public class AdministrareAngajati_FisierText : IStocareDataAngajati
    {
        private const int ID_PRIMUL_ANGAJAT = 1;
        private const int INCREMENT = 1;
        private const char DELIMITER = ',';

        string NumeFisier { get; set; }
        public AdministrareAngajati_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }
        public void AddAngajat(Angajati a)
        {
            a.IdAngajat = GetId();
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                    swFisierText.WriteLine(a.ConversieLaSir(DELIMITER));
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

        public List<Angajati> GetAngajati()
        {
            List<Angajati> angajati = new List<Angajati>(); 
            
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != "")
                        {
                            Angajati a = new Angajati(line);
                            angajati.Add(a);
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

            return angajati;
        }

        public Angajati GetAngajat(string CNP)
        {
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        Angajati a = new Angajati(line);
                        if (a.Cnp == CNP)
                            return a;
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

        public Angajati GetAngajatByIndex(int index)
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
                        Angajati a = new Angajati(line);
                        if (contor == index)
                            return a;
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

        public bool UpdateAngajat(Angajati AngajatActualizat)
        {
            List<Angajati> angajati = GetAngajati();
            bool actualizareCuSucces = false;
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Angajati a in angajati)
                    {
                        if (a.IdAngajat != AngajatActualizat.IdAngajat)
                        {
                            swFisierText.WriteLine(a.ConversieLaSir(DELIMITER));
                        }
                        else
                        {
                            swFisierText.WriteLine(AngajatActualizat.ConversieLaSir(DELIMITER));
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
            int IdAngajat = ID_PRIMUL_ANGAJAT;
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Angajati a = new Angajati(line);
                        IdAngajat = a.IdAngajat + INCREMENT;
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
            return IdAngajat;
        }
    }
}
