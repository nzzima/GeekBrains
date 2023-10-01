// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int EnteringNum(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool Check (int exp)
{
    if (exp < 0)
    {
        System.Console.WriteLine("EXP (B) < 0 ! Try again");
        return false;
    }
    return true;
}

int InDegree(int A, int B)
{
    int temp = 1;
    for (int i = 0; i < B; i++)
    {
        temp *= A;
    }
    return temp;
}

int A = EnteringNum("Enter number A: ");
int B = EnteringNum("Enter number B: ");

if (Check(B))
{
    System.Console.WriteLine("A in degree B = " + InDegree(A, B));
}