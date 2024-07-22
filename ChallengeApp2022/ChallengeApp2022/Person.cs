namespace ChallengeApp2022
{
    public abstract class Person
    {
        //Konstruktor
        public Person(string name, string surname, char gender, int age)
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
    }
}