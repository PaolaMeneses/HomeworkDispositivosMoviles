
using HomeWorkDispositivosMoviles;
using System.Linq.Expressions;
PositivePower positivePower = new PositivePower();
DoubleTriple doubletriple = new DoubleTriple();
RootSquare rootSquare = new RootSquare();   
CirclePerimeter circlePerimeter = new CirclePerimeter();
MidweekDay midweekDay = new MidweekDay();
TaxCalculator taxCalculator = new TaxCalculator();
RemainderFinder remainderFinder = new RemainderFinder();
SumEvens sumEvens = new SumEvens();
FractionDifference fractionDifference = new FractionDifference();
StringLength stringLength = new StringLength();    

Console.WriteLine("Hola ha ingresado a la tarea de Paola Meneses Calderón");

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

    
    int respuesta = Convert.ToInt16(Console.ReadLine());

    int option = respuesta;

    switch (option)
    {
        case 0:
            if (respuesta == 0)
            {
                continuar = false;
            }
            break;
        case 1:

            if (respuesta == 1)
            {
                positivePower.ejecutar();
            }

            break;
        case 2:

            if (respuesta == 2)
            {
                doubletriple.ejecutar();
            }

            break;
        case 3:

            if (respuesta == 3)
            {
                rootSquare.ejecutar();
            }

            break;
        case 4:

            if (respuesta == 4)
            {
                circlePerimeter.ejecutar();
            }

            break;
        case 5:

            if (respuesta == 5)
            {
                midweekDay.ejecutar();
            }

            break;
        case 6:

            if (respuesta == 6)
            {
                taxCalculator.ejecutar();
            }

            break;

        case 7:

            if (respuesta == 7)
            {
                remainderFinder.ejecutar();
            }

            break;
        case 8:

            if (respuesta == 8)
            {
                sumEvens.ejecutar();
            }

            break;
        case 9:

            if (respuesta == 9)
            {
                fractionDifference.ejecutar();
            }

            break;

        case 10:

            if (respuesta == 10)
            {
                stringLength.ejecutar();
            }

            break;
    }

} while (continuar);
