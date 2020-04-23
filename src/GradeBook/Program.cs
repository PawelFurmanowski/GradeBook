using System;
using System.Collections.Generic;

namespace GradeBook
{

    
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Książka Pawła");
            book.GradeAdded += OnGradeAdded;
             book.GradeAdded += OnGradeAdded;
              book.GradeAdded -= OnGradeAdded;
               book.GradeAdded += OnGradeAdded;
                
        
            while(true)
            {
            Console.WriteLine("Podaj ocenę lub podaj 'q' aby wyjść: ");
            var userInput = Console.ReadLine();
            
            if(userInput == "q")
            {
                break;
            }

            try //próbujemy wykonać kod zawarty w tym bloku w przypadku błędu wykorzystywana jest klauzula catch 
            {

            
            var grade = double.Parse(userInput);
            book.AddGrade(grade);
            
            }
            catch(ArgumentException ex )
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally //zawsze wykonywane niezależnie od wyjątku np gdy chcemy zamknąć plik 
            {
                Console.WriteLine("**");
            }

            }
            
            var stats = book.GetStatistics();
            
            
            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"Największa wartość to: {stats.High}");
            Console.WriteLine($"Najmniejsza wartość to: {stats.Low}");
            Console.WriteLine($"Średnia wartość to: {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.letter}");
            
            
           
        }      

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Dodano ocenę!");
        }
    }
}
