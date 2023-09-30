// Задача 19: Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно
// палиндромом.

using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        if (number > 99999)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }
            
        if (number % 10 == number / 10000)
        {
            if (number / 10 % 10 == number / 1000 % 10)
            {
                return true;
            }
            return false;
        }
        return false;
    }
  
      static public void Main(string[] args) 
      {
        int number;

        if (args.Length >= 1) 
        {
            number = int.Parse(args[0]);
        } 
        else 
        {
            number = 123321;
        }

        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}