// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

Console.Clear();
Console.Write("Введите количество строк матрицы А: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов матрицы А: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк матрицы В: ");
int rows2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов матрицы В: ");
int columns2 = int.Parse(Console.ReadLine()!);

int[,] array1 = NewArray(rows, columns, 0, 10);
int[,] array2 = NewArray(rows2, columns2, 0, 10);

Console.WriteLine();
Console.WriteLine("Матрица А");
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Матрица B");
PrintArray(array2);
Console.WriteLine();
ArrayMultiplication(array1, array2);

int[,] NewArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void ArrayMultiplication(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) != array2.GetLength(0))
    {
        Console.Write("Умножение массивов невозжно");
    }
    else
    {
        Console.WriteLine("Матрица C = A * B");
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                    resultArray[i, j] += array1[i, k] * array2[k, j];
                }
                Console.Write($"{resultArray[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}
