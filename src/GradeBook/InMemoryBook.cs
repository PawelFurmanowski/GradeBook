using System.Collections.Generic;
using System;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

     public interface IBook 
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name{get;}
        event GradeAddedDelegate GradeAdded;

    }

    public class InMemoryBook : Book
    {         
        //konstruktor parametryczny dziedziczy po klasie podstawowej
        public InMemoryBook(string name) : base(name)
        {
            
            this.Name = name; 
            grades = new List<double>();

        }
        public void AddGrade(char letter)
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

   
        public override void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Podano nieprawidłową wartość {nameof(grade)}");
            }
        }

        public override event GradeAddedDelegate GradeAdded;

        public override Statistics GetStatistics()
        {
            Statistics result = new Statistics();

            //foreach( double grade in grades)
            for(int i = 0; i < grades.Count; i++)
            {
                result.Add(grades[i]);  
            }

            return result;
        }
        
             private List<double> grades;
           
            public const string CATEGORY = "Science"; 
        
        
    }
}