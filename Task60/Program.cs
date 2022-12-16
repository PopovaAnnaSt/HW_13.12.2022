// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.

using System;
using static System.Console;
Clear();

Write("Введите 1 параметр массива: ");
int rows = int.Parse(ReadLine());
Write("Введите 2 параметр массива: ");
int columns = int.Parse(ReadLine());
Write("Введите 3 параметр массива: ");
int depth = int.Parse(ReadLine());
if(rows*columns*depth > 99-10+1)
{
    WriteLine("Невозможно сформировать массив, размерность массива превышает количество двузначных чисел");
    return;
}

int[,,] array = GetArray(rows, columns, depth, 10, 99);
PrintArray(array);

int[,,] GetArray(int m, int n, int p, int min, int max)
{
    int[,,] result = new int[m, n, p];
    int[] checkingArray = new int[max+1];
    int randomNumber = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                while (true)
                {
                    randomNumber = new Random().Next(min, max + 1);
                    if (checkingArray[randomNumber] != 1)
                    {
                        result[i, j, k] = randomNumber;
                        checkingArray[randomNumber] = 1;
                        break;
                    }
                }
            }
        }
    }
    return result;
}
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i, j, k]} ({i},{j},{k})  ");
            }
            WriteLine();
        }
    }
}