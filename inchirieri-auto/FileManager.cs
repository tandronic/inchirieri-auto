using System;
using System.Collections.Generic;
using System.IO;

namespace inchirieri_auto
{
    class FileManager
    {
        private const int PAS_ALOCARE = 10;
        private const int NR_ELEMENTE = 6;
        string FileName { get; set; }
        public FileManager(string FileName)
        {
            this.FileName = FileName;
            Stream OpenFile = File.Open(FileName, FileMode.OpenOrCreate);
            OpenFile.Close();

        }
        public void AddMasini(Masini m)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(FileName, true))
                {
                    swFisierText.WriteLine(m.ConversieLaSirFisier());
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
        }

        public Masini[] GetMasini(out int nrMasini)
        {
            Masini[] VectorMasini = new Masini[PAS_ALOCARE];

            try
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    string line;
                    nrMasini = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == "")
                            break;
                        VectorMasini[nrMasini++] = new Masini(line);
                        if (nrMasini == PAS_ALOCARE)
                        {
                            Array.Resize(ref VectorMasini, nrMasini + PAS_ALOCARE);
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

            return VectorMasini;
        }
    }
}
