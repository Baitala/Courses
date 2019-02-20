using System;

namespace coursesTask9._1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
            Create Console Application project in VS.
            In method Main() write code for solving next tasks:
            1) define integer variables a and b.Read values a and b from Console and calculate: a+b, a-b, a*b, a/b. Output obtained results.
            2) Output question “How are you?“. Define string variable answer. Read the value answer and output: “You are (answer)". 
            */
                        
            // Defining int a
            Console.WriteLine("Please enter value for 'a'");
            string first = System.Console.ReadLine();
            int a = System.Convert.ToInt32(first);

            // Defining int b
            Console.WriteLine("Please enter value for 'b'");
            string second = System.Console.ReadLine();
            int b = System.Convert.ToInt32(second);
            
            // Calculations
            int addition = a + b;
            int substraction = a - b;
            int multiplication = a * b;
            int division = a / b;
            double divisionDouble = System.Convert.ToDouble(division);

            //Output
            Console.WriteLine("Calculations output");
            Console.WriteLine("a + b result is " + addition);
            Console.WriteLine("a - b result is " + substraction);
            Console.WriteLine("a * b result is " + multiplication);
            Console.WriteLine("a / b result is " + divisionDouble);

            // Question
            Console.WriteLine("How are you?");
            string answer = System.Console.ReadLine();
            Console.WriteLine("You are " + answer);

        }
    }
}
