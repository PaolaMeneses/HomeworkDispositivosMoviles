
using HomeWorkDispositivosMoviles;
using System.Linq.Expressions;
PositivePower positivePower = new PositivePower();
DoubleTriple doubletriple = new DoubleTriple();
RootSquare rootSquare = new RootSquare();   
CirclePerimeter circlePerimeter = new CirclePerimeter();
MidweekDay midweekDay = new MidweekDay();
Console.WriteLine("Hola ha ingresado a la tarea de Paola Meneses Calderón");

positivePower.ejecutar();
doubletriple.ejecutar();
rootSquare.ejecutar();
circlePerimeter.ejecutar();
midweekDay.ejecutar();

    

bool continuar = true;
do
{
    Console.WriteLine("Cúal tarea desea revisar ?" +
                "\n 1.PositivePower" +
                "\n 2.Double or Triple" +
                "\n 3.. Root or Square" +
                "\n 4.Circle Perimeter" +
                "\n 5.Midweek Day" +
                "\n 6.Tax Calculator" +
                "\n 7.Remainder Finder" +
                "\n 8.Sum of Evens" +
                "\n 9.Fraction Difference" +
                "\n 10.String Length" +
                "\n 11.Average of Four" +
                "\n 12.Smallest of Five" +
                "\n 13.Vowel Counter" +
                "\n 14.Factorial Finder" +
                "\n 15.InRange Validator" +
                "\n 0.Salir");

    string respuesta = Console.ReadLine();
    

    int option = 0;

    switch (option)
        {
        case 0:
            if (respuesta == "0")
            {
                continuar = false;
            } break;
        case 1:

            if (respuesta == "1")
            {
                positivePower.ejecutar();
            }
            
            break;

        }


    


} while (continuar);

