// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int Start()
{
    Console.Write("Enter number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool Validate(int number)
{
    if (number < 100)
    {
        Console.WriteLine("No third rank");
        return false;
    }
    return true;
}

int GetThird(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

int number = Start();

if (Validate(number)) Console.WriteLine("Third rank --> " + GetThird(number));