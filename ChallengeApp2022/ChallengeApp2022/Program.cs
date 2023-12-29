// Zadanie domowe Day 5

int number = 3633;
string numberAsString = number.ToString();
char[] digits = numberAsString.ToArray();

int count0 = 0;
int count1 = 0;
int count2 = 0;
int count3 = 0;
int count4 = 0;
int count5 = 0;
int count6 = 0;
int count7 = 0;
int count8 = 0;
int count9 = 0;

foreach (char digit in digits)
{
    if (digit == '0')
    {
        count0++;
    }
    else if (digit == '1')
    {
        count1++;
    }
    else if (digit == '2')
    {
        count2++;
    }
    else if (digit == '3')
    {
        count3++;
    }
    else if (digit == '4')
    {
        count4++;
    }
    else if (digit == '5')
    {
        count5++;
    }
    else if (digit == '6')
    {
        count6++;
    }
    else if (digit == '7')
    {
        count7++;
    }
    else if (digit == '8')
    {
        count8++;
    }
    else if (digit == '9')
    {
        count9++;
    }
}

Console.WriteLine("Wynik dla podanej liczby: " + number);
Console.WriteLine("cyfra 0 -> " + count0);
Console.WriteLine("cyfra 1 -> " + count1);
Console.WriteLine("cyfra 2 -> " + count2);
Console.WriteLine("cyfra 3 -> " + count3);
Console.WriteLine("cyfra 4 -> " + count4);
Console.WriteLine("cyfra 5 -> " + count5);
Console.WriteLine("cyfra 6 -> " + count6);
Console.WriteLine("cyfra 7 -> " + count7);
Console.WriteLine("cyfra 8 -> " + count8);
Console.WriteLine("cyfra 9 -> " + count9);