using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDispositivosMoviles
{
    public class SumEvens
    {
        public SumEvens() { }

        public void ejecutar()

        {

            bool continuar = true;
            do
            {
                
                int resultado = 0;

                for (int i = 2; i <= 50; i += 2)
                {
                    resultado += i;
                }

                
                Console.WriteLine("la suma de los numeros pares hasta el 50 " + " " + "es: " + resultado);




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
