﻿// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int product = 1;
for (int i=1; i<=N; i++)
{
   product = product * i;
}
Console.WriteLine(product);