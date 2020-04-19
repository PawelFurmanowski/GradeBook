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
            book.AddGrade(90.4);
            
            
            
            
            
            
           book.ShowStatistics();
        }

             

            
    }
}
