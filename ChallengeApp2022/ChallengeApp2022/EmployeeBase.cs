namespace ChallengeApp2022
{
    public abstract class EmployeeBase : IEmployee
    {
        //Delegat
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        //Event
        public abstract event GradeAddedDelegate GradeAdded;

        // Konstruktor
        public EmployeeBase(string name, string surname, char gender, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;
        }

        //Właściwości
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Gender { get; private set; }
        public int Age { get; private set; }

        //Metody
        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(short grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatisticsWithForeach();
        
    }
}
