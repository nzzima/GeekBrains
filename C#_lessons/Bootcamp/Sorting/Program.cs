using static Sorting;

int[] array = new int[] {9, 6, 0, 5, 7, 3, 1, 2};
System.Console.WriteLine(string.Join(' ', array));
array.SortSelection();
System.Console.WriteLine(string.Join(' ', array));