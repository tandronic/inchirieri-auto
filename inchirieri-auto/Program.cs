using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchirieri_auto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test clasa Masini
            var masina = new Masini("Audi", "A4", "WAUZZZF49HA036784", 2017, 1986, false);
            Console.WriteLine(masina.Info());
            Console.ReadKey();
        }
    }
}
