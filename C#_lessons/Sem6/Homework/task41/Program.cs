// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Start()
{
    System.Console.Write("How many numbers you want to enter: ");
    int M = Convert.ToInt32(Console.ReadLine());
    return M;
}

bool Check_M (int M)
{
    if (M < 1)
    {
        System.Console.WriteLine("Can't enter 0 or less numbers. Try again.");
        return false;
    }
    return true;
}

int[] EnterNums (int M)
{
    int[] data = new int[M];
    for(int index = 0; index < M; index++)
    {
        System.Console.Write($"Enter {index + 1} number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        data[index] = number;
    }
    return data;
}

void PrintEnteredNums(int[] data)
{
    System.Console.Write("Entered numbers: [");
    for(int index = 0; index < data.Length; index++)
    {
        if (index == data.Length - 1) System.Console.Write($"{data[index]}");
        else System.Console.Write($"{data[index]}" + ", ");
    }
    System.Console.Write("]");
}

int Check_and_Count_PositiveNums (int[] data)
{
    int count = 0;
    for(int index = 0; index < data.Length; index++)
    {
        if (data[index] > 0) count++;
    }
    return count;
}

int M = Start();

if (Check_M(M))
{
    int[] enteredNums = EnterNums(M);
    PrintEnteredNums(enteredNums);
    int count = Check_and_Count_PositiveNums(enteredNums);
    System.Console.WriteLine($"\nCount of positive = {count}");
}