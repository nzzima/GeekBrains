//Задача 2. Первое число - квадрта второго ?

Console.Write("Enter number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}