using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {
         
        public string Name;
         private List<double> grades;
         
        public Book(string name)
        {
            this.Name = name; 
            grades = new List<double>();

        }

        public void AddLetterGrade(char letter)
        {
            if(!char.IsUpper(letter))
            {
                letter = char.ToUpper(letter);
            }

            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                
                default:
                    AddGrade(0);
                    break;


            }
            

        }
        

        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Podano nieprawidłową wartość {nameof(grade)}");
            }
        }

        public Statistics GetStatistics()
        {
            Statistics result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            
            //foreach( double grade in grades)
            for(int i = 0; i < grades.Count; i++)
            {
                if(grades[i] == 42.1)
                {
                    break;
                    
                }

                result.High = Math.Max(grades[i], result.High); //szukanie największej oceny
                result.Low = Math.Min(grades[i], result.Low); //szukanie najmniejszej oceny

                result.Average += grades[i];
                
            }

            result.Average = result.Average/grades.Count; //średnia ocen

            switch(result.Average)
            {
                case var d when d >= 90.0:
                    result.letter = 'A';
                    break;

                case var d when d >= 80.0:
                    result.letter = 'B';
                    break;

                case var d when d >= 70.0:
                    result.letter = 'C';
                    break;

                case var d when d >= 60:
                    result.letter = 'D';
                    break;
                
                default:
                    result.letter = 'F';
                    break;
            }

            return result;
        }
        
        
        
    }
}