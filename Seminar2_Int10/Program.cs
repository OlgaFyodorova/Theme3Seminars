//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Enter number (от 100 до 999): ");
int number = int.Parse(Console.ReadLine());

int num1 = number / 100;

int num2 = (number - num1 * 100) / 10;

System.Console.WriteLine(num2);