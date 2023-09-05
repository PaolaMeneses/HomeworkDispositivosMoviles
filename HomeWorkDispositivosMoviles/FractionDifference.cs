using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDispositivosMoviles
{
    public class FractionDifference
    {
        public FractionDifference() { }

        public void ejecutar()

        {

            bool continuar = true;
            do
            {
           
                Console.WriteLine("Calcular la diferencia entre fracciones");

                Console.Write("Ingrese el numerador de la primera fracción: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el denominador de la primera fracción: ");
                int denom1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el numerador de la segunda fracción: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el denominador de la segunda fracción: ");
                int denom2 = Convert.ToInt32(Console.ReadLine());

                // Verificar si los denominadores son diferentes de cero
                if (denom1 != 0 && denom2 != 0)
                {
                    // Calcular la diferencia de fracciones
                    int nvoNum = (num1 * denom2) - (num2 * denom1);
                    int nvoDenom = denom1 * denom2;

                    Console.WriteLine("La diferencia entre las fracciones es: " + nvoNum + "/" + nvoDenom);
                }
                else
                {
                    Console.WriteLine("Los denominadores no pueden ser cero. ¡Inténtalo de nuevo!");
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
