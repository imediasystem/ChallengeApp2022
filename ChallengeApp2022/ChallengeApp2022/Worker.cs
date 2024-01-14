namespace ChallengeApp2022
{
    public class Worker
    {
        public List<int> rate = new List<int>();
        public Worker(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return this.rate.Sum();
            }
        }

        public void AddRate(int rate)
        {
            this.rate.Add(rate);
        }
    }
}
