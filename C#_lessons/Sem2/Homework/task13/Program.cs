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

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());;

if (Validate(number)) Console.WriteLine("Third number --> " + GetThird(number));