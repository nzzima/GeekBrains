// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Start()
{
    Console.Write("Enter day: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool CheckDay (int day)
{
    if ((day >= 1) && (day <= 7))
    {
        Console.WriteLine("Check day: OK!");
        return true;
    }
    Console.WriteLine("Check day: OUT OF RANGE!");
    return false;
}

bool IsWeekend (int day)
{
    if (day > 5) 
    {
        return true;
    }
    return false;
}

int day = Start();

if (CheckDay(day))
{
    if (IsWeekend(day))
    {
        Console.WriteLine("Finally weekend :)");
    }
    else
    {
        Console.WriteLine("Work again :(");
    }
}