namespace ChallengeApp2022.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectAllGrades_ShouldReturnMaxGrade()
        {
            var employee1 = new Employee("Zenon", "Kalicki", 'M', 32);
            employee1.AddGrade(50);
            employee1.AddGrade(40);
            employee1.AddGrade(70);

            var statistics1 = employee1.GetStatisticsWithForeach();

            Assert.AreEqual(70, statistics1.Max);
        }

        [Test]
        public void WhenEmployeeCollectAllGrades_ShouldReturnMinGrade()
        {
            var employee2 = new Employee("Karol", "Mazur", 'M', 34);
            employee2.AddGrade(60);
            employee2.AddGrade(70);
            employee2.AddGrade(80);

            var statistics2 = employee2.GetStatisticsWithForeach();

            Assert.AreEqual(60, statistics2.Min);
        }

        [Test]
        public void WhenEmployeeCollectAllGrades_ShouldReturnAverage()
        {
            var employee3 = new Employee("Jakub", "Kowalski", 'M', 27);
            employee3.AddGrade(90);
            employee3.AddGrade(60);
            employee3.AddGrade(70);

            var statistics3 = employee3.GetStatisticsWithForeach();

            Assert.AreEqual(73.33333333f, statistics3.Average);
        }

        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnAverageLetterValue()
        {
            var employee1 = new Employee("Zenon", "Kalicki", 'M', 32);
            employee1.AddGrade(50);
            employee1.AddGrade(40);
            employee1.AddGrade(70);

            var statistics4 = employee1.GetStatisticsWithForeach();

            Assert.AreEqual('C', statistics4.AverageLetter);
        }
    }
}
