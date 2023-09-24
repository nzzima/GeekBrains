using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      int temp = 1;
      while (temp <= number)
      {
        if (temp % 2 == 0)
        {
          Console.Write(temp);
          Console.Write("   ");
        }
        temp++;
      }
    }


    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            number = 25;
        }

        PrintEvenNumbers(number);
    }
}