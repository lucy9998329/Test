using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
            /*Console.WriteLine("Enter in your first name");
            var fname = Console.ReadLine();
            Console.WriteLine("Enter in your last name");
            var lname = Console.ReadLine();
            Console.WriteLine($"Your name is {fname} {lname}");
            Console.ReadLine();*/

            
            /*var counter = 12;

            Console.WriteLine("Please enter in a number");
            var number = int.Parse(Console.ReadLine());

            for (var i = 1; i <= counter; i++)
                {
                Console.WriteLine($"{number} x {i} = {number * i}");
                Console.ReadLine();

                }*/


            /*var counter = 12;
            Console.WriteLine("Please enter in a number");
            var number = int.Parse(Console.ReadLine());

            for (var i = 0; i < counter; i++)
                {
                var a = i + 1;
                Console.WriteLine($"{number} x {a} = {number * a}");
                //Console.ReadLine();

                }*/


                /*var number = 0;
                var counter = 5;

                for (var i = 0; i < counter; i++)
                {
                    Console.WriteLine("Please enter in a number");
                    var userInput = int.Parse(Console.ReadLine());

                    number += userInput;
                }
                    Console.WriteLine($"The total is {number}");
                    Console.WriteLine($"The average is {number/counter}");*/


                    


            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
            
        }
    }
}
