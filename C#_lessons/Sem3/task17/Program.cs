// Задача 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.Write("Enter X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if ((X > 0) && (Y > 0)) Console.WriteLine("Quarter number is 1");
else if ((X < 0) && (Y > 0)) Console.WriteLine("Quarter number is 2");
else if ((X < 0) && (Y < 0)) Console.WriteLine("Quarter number is 3");
else if ((X > 0) && (Y < 0)) Console.WriteLine("Quarter number is 4");