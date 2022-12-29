// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] arr = NewArray(5, 5, 0, 10);
PrintArray(arr);
Console.WriteLine();
SortArray(arr);
PrintArray(arr);

int[,] NewArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
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

void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int maxElem = j;                                    
            for (int m = j + 1; m < arr.GetLength(1); m++)      
            {
                if (arr[i, m] > arr[i, maxElem]) maxElem = m;
            }
            int temp = arr[i, j];
            arr[i, j] = arr[i, maxElem];
            arr[i, maxElem] = temp;
        }
    }
}
