// Задача 3.
// Напишите программу, которая будет принимать на вход
// 2 числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Enter number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Некратно, остаток равен " + num1 % num2);    //Канкатинация (temp1 + "text" + temp2 + "text");
    Console.WriteLine($"Некратно, остаток равен {num1 % num2}");    //Интерполяция
    Console.WriteLine(num1 + "\t" + num2);                          //Табуляция
    Console.WriteLine(num1 + "\n" + num2);                          //С новой строки
}