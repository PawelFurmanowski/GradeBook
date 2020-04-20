using System;
using System.Collections.Generic;

namespace GradeBook
{

    
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Książka Pawła");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
           
            
            var stats = book.GetStatistics();
            
           
            Console.WriteLine($"Największa wartość to: {stats.High}");
            Console.WriteLine($"Najmniejsza wartość to: {stats.Low}");
            Console.WriteLine($"Średnia wartość to: {stats.Average:N1}");
            
            
           
        }

             

            
    }
}
