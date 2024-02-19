using ChallengeApp2022;

var employee1 = new Employee("Adam", "Nowak", 32);
employee1.AddGrade(5);
employee1.AddGrade(4);
employee1.AddGrade(7);
var statistics1 = employee1.GetStatistics();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Pracownik {employee1.Name} {employee1.Surname} lat {employee1.Age} osiągnął następujące wyniki:");
Console.WriteLine($"Average: {statistics1.Average:F2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.ResetColor();

var employee2 = new Employee("Karol", "Theus", 34);
employee2.AddGrade(6);
employee2.AddGrade(7);
employee2.AddGrade(8);
var statistics2 = employee2.GetStatistics();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"\nPracownik {employee2.Name} {employee2.Surname} lat {employee2.Age} osiągnął następujące wyniki:");
Console.WriteLine($"Average: {statistics2.Average:F2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.ResetColor();

var employee3 = new Employee("Jakub", "Kowalski", 27);
employee3.AddGrade(9);
employee3.AddGrade(6);
employee3.AddGrade(7);
var statistics3 = employee3.GetStatistics();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\nPracownik {employee3.Name} {employee3.Surname} lat {employee3.Age} osiągnął następujące wyniki:");
Console.WriteLine($"Average: {statistics3.Average:F2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.ResetColor();