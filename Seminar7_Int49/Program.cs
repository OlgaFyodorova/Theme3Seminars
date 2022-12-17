/* Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты. */

Console.Write("Введите количество строк массива: ");
var rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

var array = GetArrayMatrix(rows, columns, -10, 100);

PrintArray(array);
CheckMassive(array);
Console.WriteLine();

PrintArray(array);

int[,] GetArrayMatrix(int rows, int columns, int minValue = 0, int maxValue = 100)
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

void CheckMassive(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                inArray[i, j] = Convert.ToInt32(Math.Pow(inArray[i, j], 2));

            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}