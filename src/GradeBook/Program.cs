﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            var book = new Book("Niro's Book Grading");
            while(true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //Use in any case to do something i.e. close file, clsoe ports
                    Console.WriteLine("*****");
                }
            }

            var stats = book.GetStatistics();

            Console.WriteLine($"{book.Name} Statistics");
            Console.WriteLine($"The lowest grade is {stats.Low}.");
            Console.WriteLine($"The higest grade is {stats.High}.");
            Console.WriteLine($"The average grade is {stats.Average:N1}.");
            Console.WriteLine($"The letter grade is {stats.Letter}.");

        }
    }
}
