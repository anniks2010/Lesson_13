using System;
using System.Collections.Generic;
using System.Linq;

namespace AgeInSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new DateTime(1986, 04, 18);
            var end = DateTime.Now;

            var age = end - start;
            Console.WriteLine(age.TotalSeconds);
          

           /// Console.ReadLine();

            ///////////////////////////////////////////

            Console.WriteLine("Name three colors");
            string userInput = Console.ReadLine();

            string[] colors = userInput.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> colorList = colors.ToList();

            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("Add/remove a color");
            string userChoise = Console.ReadLine();

            if (userChoise.ToLower()== "add")
            {
                Console.WriteLine("Enter new color:");
                string userAnswer = Console.ReadLine();
                colorList.Add(userAnswer);
            }
            
            else if(userChoise.ToLower() == "remove")
            {
                Console.WriteLine("Enter a color to remove");
                string userAnswer = Console.ReadLine();
                colorList.Remove(userAnswer);
            }
            else
            {
                Console.WriteLine("Unknow command");
            }

            foreach(string color in colorList)
            {
                Console.WriteLine(color);
            }
            
            Console.ReadLine();

        }
    }
}
