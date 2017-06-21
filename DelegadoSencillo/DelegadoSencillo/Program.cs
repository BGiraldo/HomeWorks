using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegadoSencillo
{

    public delegate void MiDelegado(String msj);

    class Program
    {
        static void Main(string[] args)
        {

            // Uso del delegado en metodo de la clase radio

            MiDelegado delegado = new MiDelegado(CRadio.metodoRadio);

            delegado("Hola a todos");


            // Uso del delegado en metodo de la clase pastel

            delegado = new MiDelegado(CPastel.mostrarPastel);

            delegado("Good Day");

            Thread.Sleep(2000000);


        }
    }
}
