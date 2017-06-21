using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadoSencillo
{
    class CRadio
    {

        public static void metodoRadio(String pMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la clase Radio");
            Console.WriteLine("Este es tu texto {0}", pMensaje);
        }


    }
}
