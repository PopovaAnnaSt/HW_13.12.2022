// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

using System;
using static System.Console;
Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

if (rows != columns)
{
    WriteLine("Количество строк должно быть равно количеству столбцов");
    return;
}

int[,] array = GetSpiralArray(rows, columns);
PrintArray(array);

int[,] GetSpiralArray(int m, int n)
{
    int[,] result = new int[m, n];
    int i = 0, j = 0;
    int num = 1;

    while (m != 0 && n != 0)
    {
        int k = 0;
        do { result[i, j++] = num++; }
        while (++k < m - 1);
        for (k = 0; k < m - 1; k++)
        {
            result[i++, j] = num++;
        }
        for (k = 0; k < m - 1; k++)
        {
            result[i, j--] = num++;
        }
        for (k = 0; k < m - 1; k++)
        {
            result[i--, j] = num++;
        }
        ++i; ++j;
         
        if (m < 2)
        {
            m = 0;
        }
        else m = m - 2;
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]:D2} ");
        }
        WriteLine();
    }
}