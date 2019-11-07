using System;

namespace ThrowSecond
{
    class Program
    {
        static void Main(string[] args)
        {
                GetAge();               
        }
        public static void GetAge ()
        {
            try
            {
                Console.WriteLine("Enter your year of birth:"); ///try sisse panna ainult need andmed, mille kvaliteedis ei ole kindel
                int userYearOfBirth = int.Parse(Console.ReadLine());

                int userAge = 2019 - userYearOfBirth;
                Console.WriteLine($"Your Age is {userAge}");
               
            }
            catch 
            {
                Console.WriteLine("You have used wrong format.");
                GetAge(); ///kutsume funktsiooni funktiooni sees.
                
            }
           
        }
    }
}
