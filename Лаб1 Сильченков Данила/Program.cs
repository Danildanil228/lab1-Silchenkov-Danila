Console.Write("Введите значение для переменной A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите значение для переменной B: ");
int b = int.Parse(Console.ReadLine());
int count = 0;
Console.WriteLine("Числа в порядке убывания: ");
for (int i = b-1; i>a;i--)
{
    Console.WriteLine(i+" ");
    count++;
}
Console.WriteLine("Количество чисел: "+count);
