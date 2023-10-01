// Задача 24: Напишите программу, которая принимает на вход
//  число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Enter number: ");
int num= Convert.ToInt32(Console.ReadLine());

int GetSunNum()
{
    int i =1;
    int sum=0;

    while(i<=num)
    {
        sum= sum+i;
        i++;
    }

    return sum;
}

int result = GetSunNum();
System.Console.WriteLine(result);