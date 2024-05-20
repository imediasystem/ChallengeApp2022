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

var statistics = employee1.GetStatisticsWithForeach();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nPracownik {employee1.Name} {employee1.Surname} lat {employee1.Age} osiągnął następujące wyniki:");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average:F2}");
Console.WriteLine($"Ocena Min: {statistics.Min}");
Console.WriteLine($"Ocena Max: {statistics.Max}");
Console.WriteLine($"Ilość ocen branych pod uwagę: {statistics.NumberOfRatings}");
Console.ResetColor();