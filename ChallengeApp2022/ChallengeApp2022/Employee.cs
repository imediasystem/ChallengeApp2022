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
            var statistics1 = new Statistics();
            statistics1.Average = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;
            statistics1.NumberOfRatings = 0;
                
            foreach (var grade in this.grades)
            {
                statistics1.Max = Math.Max(statistics1.Max, grade);
                statistics1.Min = Math.Min(statistics1.Min, grade);
                statistics1.Average += grade;
                statistics1.NumberOfRatings = this.grades.Count;
            }
            statistics1.Average /= this.grades.Count;
            return statistics1;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics2 = new Statistics();
            statistics2.Average = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;
            statistics2.NumberOfRatings = 0;

            var index2 = 0;

            while (index2 < this.grades.Count)
            {
                statistics2.Max = Math.Max(statistics2.Max, this.grades[index2]);
                statistics2.Min = Math.Min(statistics2.Min, this.grades[index2]);
                statistics2.Average += this.grades[index2];
                statistics2.NumberOfRatings = this.grades.Count;
                index2++;
            }
            statistics2.Average /= this.grades.Count;
            return statistics2;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Average = 0;
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;
            statistics3.NumberOfRatings = 0;

            var index3 = 0;

            do
            {
                statistics3.Max = Math.Max(statistics3.Max, this.grades[index3]);
                statistics3.Min = Math.Min(statistics3.Min, this.grades[index3]);
                statistics3.Average += this.grades[index3];
                statistics3.NumberOfRatings = this.grades.Count;
                index3++;
            }
            while (index3 < this.grades.Count);

            statistics3.Average /= this.grades.Count;
            return statistics3;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics4 = new Statistics();
            statistics4.Average = 0;
            statistics4.Max = float.MinValue;
            statistics4.Min = float.MaxValue;
            statistics4.NumberOfRatings = 0;

            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics4.Max = Math.Max(statistics4.Max, this.grades[i]);
                statistics4.Min = Math.Min(statistics4.Min, this.grades[i]);
                statistics4.Average += this.grades[i];
                statistics4.NumberOfRatings = this.grades.Count;
            }
            statistics4.Average /= this.grades.Count;
            return statistics4;
        }
    }
}
