using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDispositivosMoviles
{
    public class CirclePerimeter
    {
        public CirclePerimeter() { }
        public void ejecutar()

        {

            bool continuar = true;
            do
            {
                Console.WriteLine("Escribir el radio de un circulo");
                int X = Convert.ToInt16(Console.ReadLine());


                double resultado;
                

                    resultado = double.Pi*(2*X);
                    Console.WriteLine("El perimetro del circulo" + " "+ "es" + " " + resultado);
               

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
