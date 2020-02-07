//
/* 
Author: Paula Marin
Date: 02/06/2020
Comments: This C# console application code demonstrates 
the use of Methods 
*/

using System;

namespace Methods_Paula
{
    class Program
    {
        static void Main(string[] args)
        {
            // user input 
            Console.Write("Please enter your name:");

            // validate errors
            try
            {
                // Read input from user.
                string name = Console.ReadLine();


                // Method call and user's name.
                User_Name(name);

            }
            catch
            {
            }
        }

        // Customer method called User_Name
        private static string User_Name(string get_name)
        {
            // Extra space
            Console.WriteLine("");
            // Display Hello and user's name in a message.
            Console.Write("Hello " + get_name + "!");

            // Return the value.
            return get_name;
        }
    }

}

