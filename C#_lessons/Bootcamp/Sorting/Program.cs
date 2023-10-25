using static Sorting;
using static Infrastructure;
using System.Diagnostics;

int size = 100000;

20.CreateArray().Show().SortSelection().Show();
20.CreateArray().Show().SortBubble().Show();
20.CreateArray().Show().SortBubbleOptimized().Show();
20.CreateArray().Show().SortCounting().Show();
20.CreateArray().Show().SortQuick(0, 19).Show();

int[] array = size.CreateArray();

Stopwatch timer = new Stopwatch();
timer.Start();
int[] sortedSelectArray = array.SortSelection(); 
timer.Stop();
System.Console.WriteLine($"Sort selection: {timer.ElapsedMilliseconds} ms ");

timer.Reset();

timer.Start();
int[] sortedBubbleBasicArray = array.SortBubble();
timer.Stop();
System.Console.WriteLine($"Sort bubble (basic): {timer.ElapsedMilliseconds} ms ");

timer.Reset();

timer.Start();
int[] sortedBubbleOptimizedArray = array.SortBubbleOptimized();
timer.Stop();
System.Console.WriteLine($"Sort bubble (optimized): {timer.ElapsedMilliseconds} ms ");

timer.Reset();

timer.Start();
int[] sortedCountingArray = array.SortCounting();
timer.Stop();
System.Console.WriteLine($"Sort counting: {timer.ElapsedMilliseconds} ms ");

timer.Reset();

timer.Start();
int[] sortedQuickArray = array.SortQuick(0, size - 1);
timer.Stop();
System.Console.WriteLine($"Sort quick: {timer.ElapsedMilliseconds} ms ");