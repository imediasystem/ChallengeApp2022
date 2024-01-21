namespace ChallengeApp2022.Tests
{
    public class Tests
    {
        [Test]
        public void WhenRatesAreAdded_ShouldSumReturn()
        {
            var worker1 = new Worker("Adam", "Nowak", 32);
            worker1.AddRate(5);
            worker1.AddRate(4);
            worker1.AddRate(7);

            var worker2 = new Worker("Karol", "Theus", 34);
            worker2.AddRate(6);
            worker2.AddRate(7);
            worker2.AddRate(8);

            var worker3 = new Worker("Jakub", "Kowalski", 27);
            worker3.AddRate(-9);
            worker3.AddRate(-6);
            worker3.AddRate(-12);

            var result1 = worker1.Result;

            Assert.AreEqual(16, result1);

            var result2 = worker2.Result;

            Assert.AreEqual(21, result2);

            var result3 = worker3.Result;

            Assert.AreEqual(-27, result3);
        }
    }
}