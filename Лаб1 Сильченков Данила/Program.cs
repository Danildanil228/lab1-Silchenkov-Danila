Console.WriteLine("Введите числа через пробел:");
try
{
    string input = Console.ReadLine();
    string[] inputArray = input.Split(' ');
    int[] array = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        array[i] = int.Parse(inputArray[i]);
    }
    int minElement = Min(array);
    Console.WriteLine($"Минимальный элемент массива: {minElement}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
static int Min(int[] X)
{
    if (X.Length == 0)
    {
        Console.WriteLine("Массив пуст");
        return int.MinValue;
    }
    else
    {
        return Minl(X, 0);
    }
}
static int Minl(int[] X, int k)
{
    if (k == X.Length - 1)
    {
        return X[k];
    }
    else
    {
        int minRest = Minl(X, k + 1);
        return (X[k] < minRest) ? X[k] : minRest;
    }
}
