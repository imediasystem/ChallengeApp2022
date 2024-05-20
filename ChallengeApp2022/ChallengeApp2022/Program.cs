using ChallengeApp2022;

Console.WriteLine("Witamy w aplikacji SkillCase - System Okresowej Oceny Pracownika");
Console.WriteLine("================================================================");
Console.WriteLine();

var employee1 = new Employee("Zenon", "Kalicki", 32);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var grade = Console.ReadLine();
    if (grade == "q")
        {
        break;
        }
    employee1.AddGrade(grade);
}

var statistics1 = employee1.GetStatisticsWithForeach();
var statistics2 = employee1.GetStatisticsWithForeach();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nPracownik {employee1.Name} {employee1.Surname} lat {employee1.Age} osiągnął następujące wyniki:");
Console.WriteLine($"Average Letter: {statistics2.AverageLetter}");
Console.WriteLine($"Average: {statistics1.Average:F2}");
Console.WriteLine($"Ocena Min: {statistics1.Min}");
Console.WriteLine($"Ocena Max: {statistics1.Max}");
Console.WriteLine($"Ilość ocen branych pod uwagę: {statistics1.NumberOfRatings}");
Console.ResetColor();