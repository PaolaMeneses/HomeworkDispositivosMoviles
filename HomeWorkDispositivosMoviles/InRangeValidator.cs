using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDispositivosMoviles
{
    public class InRangeValidator
    {
        public InRangeValidator() { }

        public void ejecutar()
        {
            bool continuar = true;
            do
            {
                Console.WriteLine("Introduce un número:");
                Console.WriteLine("Numero: ");
                int X = Convert.ToInt16(Console.ReadLine());
               
                string resultado;

                if(X >=10 && X <= 20)
                {
                    Console.WriteLine("Esta en el rango");

                }
                else
                {
                    Console.WriteLine(" Fuera del rango");
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

