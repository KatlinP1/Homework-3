using System;

namespace Homework3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Write a program in C# Sharp that converts Fahrenheit into Celcius and vice versa.
            //- The program enables the user to select if the user wants to convert into Celcius or into Farenheit.
            //- After the user has made their choice, the program asks for an input, performs calculations and displays the result
            //0 °C = 32 °F (temperatuuri erinevus)
            
            
            Console.WriteLine("Hello! How would you like to insert the temperature (Celcius or Fahrenheit)?");
            Console.WriteLine("Enter C to convert given temperature to Celsius. F to convert given temperature to Fahrenheit:");
            var input="";
            float result=0;
            
            //õige sisendi kontroll 
            while (input != "C" && input != "F")
            {
                Console.WriteLine("Please, enter C or F!");
                input = Console.ReadLine()?.ToUpper();
            }

            string temp;
            float tempFloat;
            
            do
            {
                Console.WriteLine("Enter the temperature: ");
                temp = Console.ReadLine();
                
            } while (!float.TryParse(temp, out tempFloat));
            
           Console.Clear();
            
            if (input == "C")
            {
                //- celsius = (fahrenheit - 32) * 5 / 9;
                result = ((tempFloat - 32) * 5) / 9;
                Console.WriteLine($"{temp} °F = {result} °C");
            }
            else if (input == "F")
            {
                //- fahrenheit = (celsius * 9) / 5 + 32;
                result = ((tempFloat * 9) / 5) + 32;
                Console.WriteLine($"{temp} °C = {result} °F");
            
            }

            Console.ReadLine();
            
        }
    }
}