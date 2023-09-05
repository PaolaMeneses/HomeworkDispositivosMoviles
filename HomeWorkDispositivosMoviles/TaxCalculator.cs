using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDispositivosMoviles
{
    public class TaxCalculator
    {
        public TaxCalculator() { }

        public void ejecutar()

        {

            bool continuar = true;
            do
            {
                Console.WriteLine("Ingrese su salario anual");
                int X = Convert.ToInt16(Console.ReadLine());


                double resultado;
                if (X > 12000)
                {

                    resultado = (X - 12000)*(0.15);
                    Console.WriteLine("El valor a pagar de impuestos es " + "" + resultado);
                }
                else
                {
                    
                    Console.WriteLine("No debe pagar impuestos");
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
