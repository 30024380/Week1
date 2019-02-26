using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogansApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Makes the background color White
            Console.BackgroundColor = ConsoleColor.White;
            //Makes the text color DarkRed
            Console.ForegroundColor = ConsoleColor.DarkRed;
            int age;
            string name;
            //This code will show Enter Your Age in another prompt
            Console.WriteLine("Enter Your Age:"); 
            //This code keeps the previous code up until its manually closed
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Name:");
            name = Console.ReadLine();

            // This code displays the age
            Console.WriteLine(name + age);
            // This code constantly displays the age
            Console.ReadLine();
        }
    }
}
