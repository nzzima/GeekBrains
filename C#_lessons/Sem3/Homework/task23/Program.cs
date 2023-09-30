// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;

public class Answer
{
   static void ShowCube(int N)
    {
        int temp = 1;
        while (temp <= N)
        {
            Console.WriteLine(temp * temp * temp);
            temp++;
        }
    }

      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
            N = 5;
        }

        ShowCube(N);
    }
}