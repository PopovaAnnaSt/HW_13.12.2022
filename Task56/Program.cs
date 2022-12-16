// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
WriteLine();
int[] sumArray = SumInString(array);
WriteLine();
WriteLine($"Наименьшая сумма элементов в {Index(sumArray)} строке");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int[] SumInString(int[,] inArray)  //формирование массива из сумм элементов каждой строки
{
    int[] result = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += array[i, j];
            result[i] = sum;
        }
    }
    Write($"{String.Join(" ", result)} (для проверки)");
    return result;
}

int Index(int[] array)  //нахождение индекса строки с минимальной суммой элементов
{
    int min = array[0];
    int indexMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            indexMin = i;
        }
    }
    return indexMin;
}
