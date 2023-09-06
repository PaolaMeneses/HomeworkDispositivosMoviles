using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDispositivosMoviles
{
    public class AverageFour
    {
        public AverageFour() { }

        public void ejecutar()

        {

            bool continuar = true;
            do
            {
                Console.WriteLine("Introduce cuatro números:");
                Console.WriteLine("Numero 1:");
                int X = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Numero 2 :");
                int N = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Numero: 3");
                int M = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Numero 4:");
                int L = Convert.ToInt16(Console.ReadLine());

                double resultado;
               

                    resultado = (X+N+M+L)/4;
                    Console.WriteLine("El promedio " + " "  + "es: " + resultado);
               

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
