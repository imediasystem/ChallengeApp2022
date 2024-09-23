using static ChallengeApp2022.EmployeeBase;

namespace ChallengeApp2022
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        char Gender { get; }

        int Age { get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(char grade);

        void AddGrade(short grade);

        void AddGrade(int grade);

        void AddGrade(long grade);

        void AddGrade(double grade);

        event GradeAddedDelegate GradeAdded;


        Statistics GetStatisticsWithForeach();
    }
}
