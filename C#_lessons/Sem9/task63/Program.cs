// Задача 63. Задайте значение N. Напишите программу
// которая выведет все натуральные числа от 1 до N.

System.Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return start + " " + PrintNumbers(start+1, end);
}

System.Console.WriteLine(PrintNumbers(1, number));