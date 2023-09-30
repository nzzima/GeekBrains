// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1) Console.WriteLine("X > 0 and Y > 0");
else if (num == 2) Console.WriteLine("X < 0 and Y > 0");
else if (num == 3) Console.WriteLine("X < 0 and Y < 0");
else if (num == 4) Console.WriteLine("X > 0 and Y < 0");
else Console.WriteLine("No such quarter, try again ");