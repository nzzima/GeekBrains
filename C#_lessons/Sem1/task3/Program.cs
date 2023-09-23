Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

string[] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.Write("Week day: ");
Console.WriteLine(week[number - 1]);