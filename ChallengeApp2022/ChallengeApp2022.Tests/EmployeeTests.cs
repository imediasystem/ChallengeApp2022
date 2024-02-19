namespace ChallengeApp2022.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectAllGrades_ShouldReturnMaxGrade()
        {
            var employee1 = new Employee("Adam", "Nowak", 32);
            employee1.AddGrade(5);
            employee1.AddGrade(4);
            employee1.AddGrade(7);

            var statistics1 = employee1.GetStatistics();

            Assert.AreEqual(7, statistics1.Max);
        }

        [Test]
        public void WhenEmployeeCollectAllGrades_ShouldReturnMinGrade()
        {
            var employee2 = new Employee("Karol", "Theus", 34);
            employee2.AddGrade(6);
            employee2.AddGrade(7);
            employee2.AddGrade(8);

            var statistics2 = employee2.GetStatistics();

            Assert.AreEqual(6, statistics2.Min);
        }

        [Test]
        public void WhenEmployeeCollectAllGrades_ShouldReturnAverage()
        {
            var employee3 = new Employee("Jakub", "Kowalski", 27);
            employee3.AddGrade(9);
            employee3.AddGrade(6);
            employee3.AddGrade(7);

            var statistics3 = employee3.GetStatistics();

            Assert.AreEqual(7.33333349f, statistics3.Average);
        }
    }
}
