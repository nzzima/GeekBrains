// Задача 4.
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 7 == 0) && (num % 23 == 0))   //  && - И     || - Или
{
    Console.WriteLine("Yes");
}
else
{
     Console.WriteLine("No");
}