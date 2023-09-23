//Обратное число

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int negNumber = -1 * number;

while (negNumber <= number)
{
    Console.WriteLine(negNumber);
    negNumber++;
}