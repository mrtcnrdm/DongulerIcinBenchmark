using System.Diagnostics;

const int Iterations = 10000000; // Döngü iterasyon sayısı
var stopwatch = new Stopwatch();

#region For döngüsü performans testi
stopwatch.Start();
for (int i = 0; i < Iterations; i++)
{
}
stopwatch.Stop();
Console.WriteLine($"For döngüsü: {stopwatch.ElapsedMilliseconds} ms");
#endregion

#region Do döngüsü performans testi
stopwatch.Reset();
stopwatch.Start();
int j = 0;
do
{
    j++;
} while (j < Iterations);
stopwatch.Stop();
Console.WriteLine($"Do döngüsü: {stopwatch.ElapsedMilliseconds} ms");
#endregion

#region Parallel.for döngüsü performans testi
stopwatch.Reset();
stopwatch.Start();
Parallel.For(0, Iterations, i =>
{
});
stopwatch.Stop();
Console.WriteLine($"Parallel.for döngüsü: {stopwatch.ElapsedMilliseconds} ms");
#endregion

#region foreach döngüsü performans testi (sadece bir dizi üzerinde)
var array = new int[Iterations];
stopwatch.Reset();
stopwatch.Start();
foreach (var item in array)
{
}
stopwatch.Stop();
Console.WriteLine($"foreach döngüsü: {stopwatch.ElapsedMilliseconds} ms");
#endregion