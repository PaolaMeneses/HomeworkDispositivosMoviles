using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDispositivosMoviles
{
   
}
public class PositivePower
{
    public PositivePower()
    {


    }

    public void ejecutar()

    {

        bool continuar = true;
        do
        {
            Console.WriteLine("Escribir un numero para elevar al cuadrado");
            int X = Convert.ToInt16(Console.ReadLine());
            if (X < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
            else
            {
                double resultado;
                resultado = Math.Pow(X, 2);

                Console.WriteLine(resultado);
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
