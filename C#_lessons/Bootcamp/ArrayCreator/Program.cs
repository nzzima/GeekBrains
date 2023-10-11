using static ArrayCreator;
using static ArrayMath;
using System.Diagnostics;

int[] array = 1_000_000.Create()
                .Fill(1, 10);
// array.ConvertToStringandPrintToTerminal();

int m = 10000;

Stopwatch sw = new Stopwatch();
sw.Start();
int max = array.BadGetSum(m);
sw.Stop();

System.Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
max = array.GoodGetSum(m);
sw.Stop();
System.Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");