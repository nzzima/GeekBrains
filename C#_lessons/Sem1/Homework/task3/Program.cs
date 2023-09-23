using System;

class Answer {
    static void CheckIfEven(int number)
    {
      if (number % 2 == 0)
      {
        Console.WriteLine($"Число `{number}` чётное");
      }
      else if (number % 2 != 0)
      {
        Console.WriteLine($"Число `{number}` нечётное");
      }
    }
  

    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            number = 6;
        }

        CheckIfEven(number);
    }
}