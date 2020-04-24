using System;
namespace GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Sum / Count;

            }
        }
        public double High;
        public double Low;
        public char letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90.0:
                        return 'A';

                    case var d when d >= 80.0:
                        return 'B';
                        
                    case var d when d >= 70.0:
                        return 'C';
                        
                    case var d when d >= 60:
                        return 'D';
                        
                    default:
                        return 'F';
                        
                }
            }

        }
        public double Sum;
        public int Count;





        public Statistics()
        {
            Count = 0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }

        public void Add(double number)
        {
            Sum += number;
            Count++;
            High = Math.Max(number, High); //szukanie największej oceny
            Low = Math.Min(number, Low); //szukanie najmniejszej oceny

        }

    }

}