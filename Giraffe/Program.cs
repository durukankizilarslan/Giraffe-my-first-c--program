﻿// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);


            //Data Types in C#

            string phrase = "Giraffe Academy";
            char grade = 'A'; //character data type is a single character and can't be a group of characters like a string
            int age = 30;
            float floatNumber = 1.64F;  //Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            double gpa = 3.3; //Stores fractional numbers. Sufficient for storing 15 decimal digits
            decimal decimalNumber = 2.34M; //The decimal type is a 128-bit data type suitable for financial and monetary calculations.
                                           //It has 28-29 digit Precision. To initialize a decimal variable, use the suffix m or M. Like as, decimal x = 300.5m;. If the suffix m or M will not use then it is treated as double.
            bool isMale = true;

            //Working with strings, string attributes and string methods

            Console.WriteLine("Giraffe\nAcademy"); //used the escape character \n to skip a line
            Console.WriteLine(phrase.Length); //outputted the length of the string that is assigned to the variable phrase
            Console.WriteLine(phrase.ToUpper()); //outputted the variable phrase with all characters uppercase
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("Academy")); //Searches for a string inside the variable, returns a boolean value
            Console.WriteLine(phrase[1]); //Outputs the queried index of the string

            Console.WriteLine(phrase.IndexOf("Academy")); //Outputs the index of the queried string inside the variable

            Console.WriteLine(phrase.IndexOf("z"));// Outputs -1, which means that the string doesn't exist inside the query
            Console.WriteLine(phrase.Substring(8));//Grabs string from the index number and writes the rest starting from the index number

            Console.ReadLine();//Makes the program not close automatically after writing lines

            string[] stringArray = new string[] {"new", "string", "array"};//New string array created

            Book book1 {
                book1.title = "Lord of the Rings";
                book1.author = "Tolkien";
                book1.pages = 700;

            }

            Book book2 = new Book();
        }
    }
}  