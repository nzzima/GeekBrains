// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

System.Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

void Fibonacci (int number)
{
    if (number == 0)
    {
        System.Console.WriteLine("Error, enter number > 0 !");
        return;
    }

    int first = 0;
    int second = 1;

    System.Console.Write($"Fibonacci: {first}, {second}");

    for(int index = 2; index < number; index++)
    {
        int temp = first + second;
        first = second;
        second = temp;

        System.Console.Write(", " + temp);
    }
}

Fibonacci(number);