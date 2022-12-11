// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach (var el in array)
{   
    positiveSum += el > 0 ? el : 0;
    negativeSum += el < 0 ? el : 0;
}

Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");