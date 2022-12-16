// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

using System;
using static System.Console;
Clear();

Write("Введите количество строк массива A: ");
int rowsA = int.Parse(ReadLine());
Write("Введите количество столбцов массива A: ");
int columnsA = int.Parse(ReadLine());
int[,] arrayA = GetArray(rowsA, columnsA, 0, 9);
PrintArray(arrayA);

Write("Введите количество строк массива B: ");
int rowsB = int.Parse(ReadLine());
Write("Введите количество столбцов массива B: ");
int columnsB = int.Parse(ReadLine());
int[,] arrayB = GetArray(rowsB, columnsB, 0, 9);
PrintArray(arrayB);
//WriteLine();
WriteLine("Произведение двух матриц:");
int[,] arrayC = GetProductArray(arrayA, arrayB);
PrintArray(arrayC);

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

int[,] GetProductArray(int[,] arrayA, int[,] arrayB)
{
    if (arrayA.GetLength(1) != arrayB.GetLength(0))
    {
        WriteLine("Умножение невозможно");
    }
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}