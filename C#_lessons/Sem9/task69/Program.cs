// Задача 69: напишите программу, которая на вход принимает 
// 2 числа A и В и возводит число А в целую степень В.

System.Console.Write("Enter number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter number B : ");
int numberB = Convert.ToInt32(Console.ReadLine());

int InDegree(int number, int degree)
{
    if(degree == 0) return 1;
    else if (degree == 1) return number;
    return number * InDegree(number, degree - 1);
}

System.Console.WriteLine(InDegree(numberA, numberB));