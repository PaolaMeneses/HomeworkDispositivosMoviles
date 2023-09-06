using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWorkDispositivosMoviles
{
    public class FactorialFinder
    {
        public FactorialFinder() { }

        public void ejecutar()
        {
            bool continuar = true;
            do
            {
                Console.WriteLine("Introduce un número:");
                Console.WriteLine("Numero: ");
                int X = Convert.ToInt16(Console.ReadLine());

                if (X < 0)
                {
                    Console.WriteLine("El factorial no está definido para números negativos.");
                }
                else if (X == 0 || X == 1)
                {
                    Console.WriteLine("El factorial es: 1");
                }
                else {

                    long resultado = 1;
                    for (int i = 2; i <= X; i++)
                    {
                        resultado *= i;
                    }

                    Console.WriteLine("El factorial es: " + resultado);

                }

                
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

