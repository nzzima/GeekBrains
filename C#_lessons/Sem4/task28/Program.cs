// Задача 28: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Write("Enter number: ");
int num= Convert.ToInt32(Console.ReadLine());

int GetSumNum()
{
    int i = 1;
    int result = 1;

    while(i<=num)
    {
        result= result * i;
        i++;
    }
    return result;
}
System.Console.WriteLine(GetSumNum());