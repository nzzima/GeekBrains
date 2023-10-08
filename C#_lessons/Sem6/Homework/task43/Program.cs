// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int number_first_line = 1;
int number_second_line = 2;

double[] line1 = LinesData(number_first_line);
double[] line2 = LinesData(number_second_line);

double EnterValue(string message)
{
    System.Console.Write(message);
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

double[] LinesData (int number_of_line)
{
    double[] inputLine = new double[2];
    inputLine[0] = EnterValue($"Enter coefficient for {number_of_line} line --> ");
    inputLine[1] = EnterValue($"Enter constant for {number_of_line} line --> ");
    return inputLine;
}

double[] Find_point_of_intersection (double[] line1, double[] line2)
{
    double[] point = new double[2];

    point[0] = (line2[1] - line1[1]) / (line1[0] - line2[0]);
    point[1] = line1[0] * point[0] + line1[1];

    return point;
}

bool ValidateLines (double[] line1, double[] line2)
{
    if (line1[0] == line2[0])
    {
        if (line1[1] == line2[1])
        {
            System.Console.WriteLine("Line 1 == Line 2");
            return false;
        }
        else
        {
            System.Console.WriteLine("Line 1 || Line 2");
            return false;
        }
    }
    return true;
}

if (ValidateLines(line1, line2))
{
    double[] point_of_intersection = Find_point_of_intersection(line1, line2);
    System.Console.Write($"Point of intersaction y = {line1[0]}x + {line1[1]} and y = {line2[0]}x + {line2[1]} ");
    System.Console.Write($" is ({point_of_intersection[0]}, {point_of_intersection[1]})");
}