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
            grades = new List<double>();

        }
        

        public void AddGrade(double grade)
        {
            
          grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            Statistics result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;


            foreach( double grade in grades)
            {
                result.High = Math.Max(grade, result.High); //szukanie największej oceny
                result.Low = Math.Min(grade, result.Low); //szukanie najmniejszej oceny

                result.Average += grade;

            }
            result.Average = result.Average/grades.Count; //średnia ocen

            return result;
        }
        
        
        
    }
}