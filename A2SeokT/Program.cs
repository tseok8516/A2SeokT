/*
 * Title: Taeguk Seok Assignment 2
 * Name of Project: A2SeokT
 * Purpose: Assignment 
 * Revision History 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SeokT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Step 1: Age Fee

            Console.Write("Please enter your age in numbers: ");
            int age = Convert.ToInt32(Console.ReadLine());

            double ageFee;

            if (age <= 13)
            {
                Console.WriteLine("You can't register.");
            }
            else if (age <= 19)
            {
                ageFee = 10;
                Console.WriteLine("Your registration fee is: $" + ageFee);
            }
            else if (age >= 20 && age <= 29)
            {
                ageFee = 35.50;
                Console.WriteLine("Your registration fee is: $" + ageFee);
            }
            else if (age >= 30 && age <=64)
            {
                ageFee = 70.50;
                Console.WriteLine("Your registration fee is: $" + ageFee);
            }
            else
            {
                ageFee = 0;
                Console.WriteLine("Your registration fee is: $" + ageFee);
            }
            
            Console.ReadLine();
        }
    }
}
