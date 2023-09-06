using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDispositivosMoviles
{
    public class VowelCounter
    {
        public VowelCounter() { }


        public void ejecutar()
        {

            bool continuar = true;

            do
            {
                Console.Write("Ingresa una palabra: ");
                string palabra = Console.ReadLine().ToLower(); // Convertimos la palabra a minúsculas
                int contadorVocales = 0;

                if (palabra == null)
                {
                    return;
                }
                for (int i = 0; i < palabra.Length; i++)
                {
                    char letra = palabra[i];

                    if (EsVocal(letra))
                    {
                        contadorVocales++;
                    }
                }
                Console.WriteLine($"El número de vocales en la palabra es: {contadorVocales}");



                // Verificar si un carácter es una vocal
                static bool EsVocal(char letra)
                {
                    return "aeiouáéíóú".Contains(letra);
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



