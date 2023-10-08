// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

System.Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

string ConvertToBinary (int number)
{
    string result = "";
    while(number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    return result;
}

string result = ConvertToBinary(number);
System.Console.WriteLine($"{number} converted to binary: {result}");