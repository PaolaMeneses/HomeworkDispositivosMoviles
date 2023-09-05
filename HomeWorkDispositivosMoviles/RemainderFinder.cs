using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDispositivosMoviles
{
    public class RemainderFinder
    {
        public RemainderFinder() { }

        public void ejecutar()

        {

            bool continuar = true;
            do
            {
                Console.WriteLine("Escribir el primer numero");
                int X = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Escribir el segundo numero");
                int N = Convert.ToInt16(Console.ReadLine());

                double resultado;


                resultado = X % N;
                    Console.WriteLine("El resultado " + " " + "es" + resultado);
                
                   
                

                Console.WriteLine("Desear salir?" +
                    "\n 1.Si" +
                    "\n 0.No");

                string respuesta = Console.ReadLine();
                if (respuesta == "1")
                {
                    continuar = false;
                }


            } while (continuar);


        }
    }
}
