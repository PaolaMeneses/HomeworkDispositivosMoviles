using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDispositivosMoviles
{
    public class SmallestFive
    {
        public SmallestFive() { }

        public void ejecutar()

        {

            bool continuar = true;
            do
            {
                int cantidadNumeros = 5;
                int numeroMinimo = int.MaxValue; // Inicializamos con el valor máximo posible de un entero

                Console.WriteLine("Introduce cinco números:");

                for (int i = 0; i < cantidadNumeros; i++)
                {
                    Console.Write($"Número {i + 1}: ");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero < numeroMinimo)
                    {
                        numeroMinimo = numero;
                    }
                }

                Console.WriteLine($"El número más pequeño es: {numeroMinimo}");


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
