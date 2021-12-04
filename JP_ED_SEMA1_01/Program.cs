using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_ED_SEMA1_01
{
    class Program
    {

        static void Main(string[] args)
        {
            Lista ListaNueva = new Lista();
            ListaNueva.InsertarI(40);
            ListaNueva.InsertarI(30);
            ListaNueva.InsertarI(20);
            ListaNueva.InsertarI(10);

            ListaNueva.mostrar();

            ListaNueva.InsertarP(220,3);
            ListaNueva.mostrar();

            ListaNueva.InsertarF(120);
            ListaNueva.mostrar();

            Console.ReadKey();
        }
    }
}
