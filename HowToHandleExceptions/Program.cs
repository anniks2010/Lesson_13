using System;

namespace HowToHandleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            double number3;

            try
            {
                Console.WriteLine("Insert number 1:");
                number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Insert number 2:");
                number2 = int.Parse(Console.ReadLine());

                number3 = number1 / number2;
                Console.WriteLine(number3);

            }
            ///catch(Exception error) ////kui sulgudesse mitte panna Exception siis tuleb Writelinedesse panna errori nimi.
            catch(DivideByZeroException e)
            {
                ///Console.WriteLine(error);
                Console.WriteLine("You must not divide by zero!");
            }
            catch(FormatException e)
            {
                Console.WriteLine("You have used invalid format");
            }

           
          

            


        }
    }
}
