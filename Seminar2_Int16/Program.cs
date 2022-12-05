// Задача №16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом
//другого.
//● 5, 25 -> да
//● -4, 16 -> да
//● 25, 5 -> да
// ● 8,9 -> нет

Console.Write("Enter number1 : ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter number2 : ");
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2 * number2)
    Console.WriteLine ("Number1 is the square of Number2");
else
    Console.WriteLine ("Number1 is not the square of Number2");