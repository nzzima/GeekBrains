//Последняя цифра в трехзначном числе. 

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int lastNum = number % 10;
Console.Write("Enter last number: ");
Console.WriteLine(lastNum);