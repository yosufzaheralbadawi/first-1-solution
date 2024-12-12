using System;

namespace Assignment2

{
    internal class Program
    {
        class Person { public string Name { get; set; } }
        static void Main(string[] args)
        {
            #region Write a program that allows the user to enter a number then print it.

            Console.Write("Please enter a valid number : ");
            string input = Console.ReadLine();


            if (double.TryParse(input, out double number))
            {
                Console.WriteLine("You have entered: " + number);
            }
            else
            {
                Console.WriteLine("The entered value is not a valid number!");
            }

            #region MyRegion
            #region Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen


            int number1 = 20;
            int number2 = number1;
            Console.WriteLine("Original value of number1: " + number1);
            Console.WriteLine("Original value of number2: " + number2);


            number1 = 30;


            Console.WriteLine("New value of number1 after modification: " + number1);
            Console.WriteLine("Value of number2 remains: " + number2);

            #region Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            Person person1 = new Person { Name = "yosuf" };
            Person person2 = person1;
            Console.WriteLine("Before modification:");
            Console.WriteLine("person1.Name: " + person1.Name);
            Console.WriteLine("person2.Name: " + person2.Name);
            person2.Name = "omar";
            Console.WriteLine("After modification:");
            Console.WriteLine("person1.Name: " + person1.Name);
            Console.WriteLine("person2.Name: " + person2.Name);
            #endregion
            #endregion

            #endregion
        }

        #endregion
    }
}

