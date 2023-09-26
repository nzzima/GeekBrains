// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

bool Validate(int number)
{
    if (number < 100)
    {
        Console.WriteLine("No third number");
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

int number = new Random().Next(1, 100000);
//int number = 5;
//int number = 48;
//int number = 764;
//int number = 9162;
Console.WriteLine("Entered number --> " + number);

if (Validate(number)) Console.WriteLine("Third number --> " + GetThird(number));