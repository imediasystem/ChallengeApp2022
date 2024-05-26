using ChallengeApp2022;

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\nWitamy w aplikacji SkillCase - System Okresowej Oceny Pracownika");
Console.WriteLine("================================================================");
Console.ResetColor();
Console.WriteLine();

var employee1 = new Employee("Zenon", "Kalicki", 'M', 32);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var grade = Console.ReadLine();
    if (grade == "q")
        {
        break;
        }

    try
    {
        employee1.AddGrade(grade);
    }
    catch(Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\nException Caught!!!\n {ex.Message}");
        Console.ResetColor();
    }
    
}

var statistics = employee1.GetStatisticsWithForeach();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nPracownik {employee1.Name} {employee1.Surname} lat {employee1.Age} osiągnął następujące wyniki:");
Console.WriteLine($"Ocena Średnia: {statistics.AverageLetter}");
Console.WriteLine($"Ocena Średnia: {statistics.Average:F2}");
Console.WriteLine($"Ocena Minimalna: {statistics.Min}");
Console.WriteLine($"Ocena Maksymalna: {statistics.Max}");
Console.WriteLine($"Ilość ocen branych pod uwagę: {statistics.NumberOfRatings}");
Console.ResetColor();