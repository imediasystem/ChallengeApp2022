namespace ChallengeApp2022.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenNamesAreTheSame()
        {
            string number1 = "Adam";
            string number2 = "Adam";
            
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenDigitsAreSame()
        {
            int digit1 = 1;
            int digit2 = 2;

            Assert.AreNotEqual(digit1, digit2);
        }


        [Test]
        public void WhenNamesAreNotTheSame()
        {
            var worker1 = GetWorker("Adam");
            var worker2 = GetWorker("Karol");
            var worker3 = GetWorker("Jakub");

            Assert.AreNotEqual(worker1, worker2);
            Assert.AreNotEqual(worker2, worker3);
            Assert.AreNotEqual(worker1, worker3);

        }

        private Worker GetWorker(string name)
        {
            return new Worker(name);
        }
    }
}
