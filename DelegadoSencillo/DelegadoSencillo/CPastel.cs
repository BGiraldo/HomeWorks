using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadoSencillo
{
    class CPastel
    {

        public static void mostrarPastel(String pAnuncio)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("El pastel llevara el mensaje {0}", pAnuncio);
        }

    }
}
