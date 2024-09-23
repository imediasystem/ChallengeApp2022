﻿using System.Reflection.Metadata.Ecma335;

namespace ChallengeApp2022
{
    public class Statistics
    {
        public float Min { get; private set; }

        public float Max { get; private set; }

        public float Sum { get; private set; }

        public int NumberOfRatings { get; private set; }

        public float Average
        {
            get
            {
                return this.Sum / this.NumberOfRatings;
            }
        }

        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 80:
                        return 'A';
                    case var average when average >= 60:
                        return 'B';
                    case var average when average >= 40:
                        return 'C';
                    case var average when average >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
            this.Sum = 0;
            this.NumberOfRatings = 0;
        }

        public void AddGrade(float grade)
        {
            this.NumberOfRatings++;
            this.Sum += grade;
            this.Min = Math.Min(this.Min, grade);
            this.Max = Math.Max(this.Max, grade);
        }
    }
}