Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine());
Console.WriteLine("Введите m: ");
double m = double.Parse(Console.ReadLine());
Double H = (m * m + 2.8 * m + 0.355) / (Math.Cos(2 * y) + 3.6);
Console.WriteLine($"H={H:F2}");