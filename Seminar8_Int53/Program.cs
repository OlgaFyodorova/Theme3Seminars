﻿/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.

 */

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
CheckArray(array);
System.Console.WriteLine();
PrintArray(array);


int[,] GetArray(int rows, int columns, int minValue = 0, int maxValue = 100)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CheckArray(int[,] checkArray)
{
    int rows = checkArray.GetLength(0) - 1;
    for (int j = 0; j < checkArray.GetLength(1); j++)
    {
        int temp = checkArray[0, j];
        checkArray[0, j] = checkArray[rows, j];
        checkArray[rows, j] = temp;
    }
}
