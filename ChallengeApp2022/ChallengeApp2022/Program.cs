// Zadanie domowe Day 6

using ChallengeApp2022;

Worker worker1 = new Worker("Adam", "Nowak", 32);
Worker worker2 = new Worker("Karol", "Theus", 34);
Worker worker3 = new Worker("Jakub", "Kowalski", 27);


worker1.AddRate(5);
worker1.AddRate(4);
worker1.AddRate(7);

worker2.AddRate(6);
worker2.AddRate(7);
worker2.AddRate(8);

worker3.AddRate(9);
worker3.AddRate(6);
worker3.AddRate(7);


List<Worker> workers = new List<Worker>()
{
    worker1, worker2, worker3
};

int maxResult = -1;
Worker workerWithMaxResult = null;

foreach (var worker in workers)
{
    if (worker.Result > maxResult)

    {
        workerWithMaxResult = worker;
        maxResult = worker.Result;
    }
}

Console.WriteLine("Pracownikiem z najlepszym wynikiem zostaje" + " " + workerWithMaxResult.Name + " "
    + workerWithMaxResult.Surname + " " + "lat" + " " + workerWithMaxResult.Age + ", "
    + "który zdobył" + " " + workerWithMaxResult.Result + " " + "pkt");