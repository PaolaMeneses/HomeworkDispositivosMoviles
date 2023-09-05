using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDispositivosMoviles
{
    public class MidweekDay
    {
        public MidweekDay() { }
        public void ejecutar()

        {

            bool continuar = true;
            do
            {
                Console.WriteLine("Escribe un numero entre el 1 al 7");
                int X = Convert.ToInt16(Console.ReadLine());

                int option = 0;
                
                
                    switch (option)
                    {
                        case 1:
                          
                            Console.WriteLine("Lunes");
                            break;

                            case 2:
                                
                            Console.WriteLine("Martes");
                            break;
                            case 3:
                               
                            Console.WriteLine("Miercoles");

                            break;
                            case 4:
                                    
                            Console.WriteLine("Jueves");
                            break;
                            case 5:
                                
                            Console.WriteLine("Viernes");
                            break;
                            case 6:
                                
                            Console.WriteLine("Numero fuera del rango laboral");
                            break;
                            case 7:
                                    
                            Console.WriteLine("Numero fuera del rango laboral");
                            break;

                        default:
                            Console.WriteLine("Debe elegir entre un numero del 1 al 7 ");
                            break;
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
