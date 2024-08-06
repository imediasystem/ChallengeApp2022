using ChallengeApp2022;

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\nWitamy w aplikacji SkillCase - System Okresowej Oceny Umiejętności Pracownika");
Console.WriteLine("===============================================================================");
Console.ResetColor();
Console.WriteLine();

//var employeeInFile1 = new EmployeeInFile("Karol", "Kubiak", 'M', 34);

//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
//    var grade = Console.ReadLine();
//    if (grade == "q")
//    {
//        break;
//    }

//    try
//    {
//        employeeInFile1.AddGrade(grade);
//    }
//    catch (Exception ex)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine($"\nException Caught!!!\n {ex.Message}");
//        Console.ResetColor();
//    }
//}

//var statistics = employeeInFile1.GetStatisticsWithForeach();
//Console.ForegroundColor = ConsoleColor.DarkGreen;
//Console.WriteLine($"\nPracownik {employeeInFile1.Name} {employeeInFile1.Surname} lat {employeeInFile1.Age} osiągnął następujące wyniki:");
//Console.WriteLine($"Ocena Średnia: {statistics.AverageLetter}");
//Console.WriteLine($"Ocena Średnia: {statistics.Average:F2}");
//Console.WriteLine($"Ocena Minimalna: {statistics.Min}");
//Console.WriteLine($"Ocena Maksymalna: {statistics.Max}");
//Console.WriteLine($"Ilość ocen branych pod uwagę: {statistics.NumberOfRatings}");
//Console.ResetColor();

var employeeInMemory1 = new EmployeeInMemory("Zenon", "Kalicki", 'M', 32);
employeeInMemory1.GradeAdded += EmployeeGradeAdded;
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Dodano nową ocenę!");
    Console.ResetColor();
}

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
        employeeInMemory1.AddGrade(grade);
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\nException Caught!!!\n {ex.Message}");
        Console.ResetColor();
    }

}

var statistics = employeeInMemory1.GetStatisticsWithForeach();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nPracownik {employeeInMemory1.Name} {employeeInMemory1.Surname} lat {employeeInMemory1.Age} osiągnął następujące wyniki:");
Console.WriteLine($"Ocena Średnia: {statistics.AverageLetter}");
Console.WriteLine($"Ocena Średnia: {statistics.Average:F2}");
Console.WriteLine($"Ocena Minimalna: {statistics.Min}");
Console.WriteLine($"Ocena Maksymalna: {statistics.Max}");
Console.WriteLine($"Ilość ocen branych pod uwagę: {statistics.NumberOfRatings}");
Console.ResetColor();