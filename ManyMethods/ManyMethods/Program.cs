using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string YourName = Console.ReadLine();
            Console.WriteLine("Bye {0}!", YourName);

            Console.WriteLine("Enter first number");
            int firstnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int secondnumber = int.Parse(Console.ReadLine());

            int sum = firstnumber + secondnumber;

            Console.WriteLine("Sum is {0}", sum);
            Console.Read();

            //CatDog


            Console.WriteLine("Hello, do you like Cats or Dogs? Type 1 for Cats and 2 for Dogs");

            int result;

            if (int.TryParse(Console.ReadLine(), out result))

            {

                if (result == 1)

                    Console.WriteLine("Meow");

                else if (result == 2) 

                    Console.WriteLine("Bark");

                else

                    Console.WriteLine("Incorrect response");

            }

            else

                Console.WriteLine("Incorrect response");

            Console.ReadLine();

        }
    }
}