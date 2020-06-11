// Andronic Tudor - 3121A

using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;

namespace NivelAccesDate
{
    public class AdministrareClienti_FisierText : IStocareDataClienti
    {
        private const int ID_PRIMUL_CLIENT = 1;
        private const int INCREMENT = 1;
        private const char DELIMITER = ',';

        string NumeFisier { get; set; }
        public AdministrareClienti_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }
        public void AddClient(Clienti c)
        {
            c.IdClient = GetId();
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                    swFisierText.WriteLine(c.ConversieLaSir(DELIMITER));
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

        public List<Clienti> GetClienti()
        {
            List<Clienti> clienti = new List<Clienti>(); 
            
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != "")
                        {
                            Clienti c = new Clienti(line);
                            clienti.Add(c);
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

            return clienti;
        }

        public Clienti GetClient(string CNP)
        {
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        Clienti c = new Clienti(line);
                        if (c.Cnp == CNP)
                            return c;
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

        public Clienti GetClientByIndex(int index)
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
                        Clienti c = new Clienti(line);
                        if (contor == index)
                            return c;
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

        public bool UpdateClient(Clienti ClientActualizat)
        {
            List<Clienti> clienti = GetClienti();
            bool actualizareCuSucces = false;
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Clienti c in clienti)
                    {
                        if (c.IdClient != ClientActualizat.IdClient)
                        {
                            swFisierText.WriteLine(c.ConversieLaSir(DELIMITER));
                        }
                        else
                        {
                            swFisierText.WriteLine(ClientActualizat.ConversieLaSir(DELIMITER));
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
            int IdClient = ID_PRIMUL_CLIENT;
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Clienti c = new Clienti(line);
                        IdClient = c.IdClient + INCREMENT;
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
            return IdClient;
        }
    }
}
