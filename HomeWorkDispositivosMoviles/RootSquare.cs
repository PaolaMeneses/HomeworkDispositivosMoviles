using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDispositivosMoviles
{
    public class RootSquare
    {
        public RootSquare() { }

        public void ejecutar()

        {

            bool continuar = true;
            do
            {
                Console.WriteLine("Escribir un numero");
                int X = Convert.ToInt16(Console.ReadLine());
                

                double resultado;
                if (X <0)
                {

                    resultado = (X *X);
                    Console.WriteLine("El cuadrado de"+"" + X + "es" +""+ resultado);
                }
                else
                {
                    resultado = (Math.Sqrt(X));
                    Console.WriteLine("La raiz de "+"" + X + "es"+"" + resultado);
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
