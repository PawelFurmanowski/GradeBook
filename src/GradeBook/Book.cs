using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {
         
        private string name;
         private List<double> grades;
         
        public Book(string name)
        {
            this.name = name; 
            grades = new List<double>() {12.7, 10.3, 6.11,4.1};

        }
        

        public void AddGrade(double grade)
        {
            
          grades.Add(grade);
        }

        public void ShowStatistics()
        {
            
           
            
             double highGrade = double.MinValue;
             double lowGrade = double.MaxValue;
             double result = 0.0;

            foreach( double grade in grades)
            {
                highGrade = Math.Max(grade, highGrade); //szukanie największej oceny
                lowGrade = Math.Min(grade, lowGrade); //szukanie najmniejszej oceny

                result += grade;

            }
            result = result/grades.Count; //średnia ocen

            Console.WriteLine($"{name}");
            for (int i = 0; i<grades.Count; i++)
            {
                Console.WriteLine($"{i+1}. {grades[i]}");
            }
            Console.WriteLine($"Największa wartość to: {highGrade}");
            Console.WriteLine($"Najmniejsza wartość to: {lowGrade}");
            Console.WriteLine($"Średnia wartość to: {result}");
            

        }
        
        
        
    }
}