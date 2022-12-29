// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное значение: ");
int min = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное значение: ");
int max = int.Parse(Console.ReadLine()!);

int[,] arr = NewArray(rows, columns, min, max);

PrintArray(arr);
Console.WriteLine();
SumRows(arr);

int[,] NewArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return res;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void SumRows(int[,] arr)
{
    int minSumRow = (arr.GetLength(0) * arr.GetLength(1)) * 10;
    int indexMinSumRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки равна: {sum}");
        if (sum < minSumRow)
        {
            minSumRow = sum;
            indexMinSumRow = i + 1;
        }
    }
    Console.Write($"Строка с найменьшей суммой элементов: {indexMinSumRow} строка");
}