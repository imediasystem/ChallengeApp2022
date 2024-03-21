using System;
using System.Diagnostics;

namespace ChallengeApp2022
{
    public class Employee
    {
        
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public void AddGrade(float grade)
        {
            if(grade >= 0 && grade <=100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nCAUTION!!! Invalid grade value!!!");
                Console.ResetColor();
            }
        }
        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
                {
                this.AddGrade(result);
                }
            else
                {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nCAUTION!!! String is not float!!!");
                Console.ResetColor();
                }

        }
        public void AddGrade(char grade)
        {
            if (float.TryParse($"{grade}", out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nCAUTION!!! Char is not float!!!");
                Console.ResetColor();
            }

        }
        public void AddGrade(short grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        public void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        public Statistics GetStatisticsWithForeach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.NumberOfRatings = 0;
                
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
                statistics.NumberOfRatings = this.grades.Count;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.NumberOfRatings = 0;

            var index2 = 0;

            while (index2 < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index2]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index2]);
                statistics.Average += this.grades[index2];
                statistics.NumberOfRatings = this.grades.Count;
                index2++;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.NumberOfRatings = 0;

            var index3 = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index3]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index3]);
                statistics.Average += this.grades[index3];
                statistics.NumberOfRatings = this.grades.Count;
                index3++;
            }
            while (index3 < this.grades.Count);

            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.NumberOfRatings = 0;

            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
                statistics.NumberOfRatings = this.grades.Count;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
