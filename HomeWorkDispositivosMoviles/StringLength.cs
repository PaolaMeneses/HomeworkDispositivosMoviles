using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDispositivosMoviles
{
    public class StringLength
    {
        public StringLength() { }
        public void ejecutar()

        {

            bool continuar = true;
            do
            {
                Console.WriteLine("Inserta una palabra");
                string X = Console.ReadLine();
                

                int resultado;


                resultado = X.Length;
                Console.WriteLine("La longitud de la palabra " + " "+ X + "es" + resultado);




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
