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

int sqr;

if (number1 > number2)
{
    sqr = number2 * number2;
    if (sqr == number1)
        Console.WriteLine("Number2 is the square of Number1");
    else
    {
        Console.WriteLine("Number2 is not the square of Number1");
    }
}
else
{
    sqr = number1 * number1;
    if (sqr == number2)
        Console.WriteLine("Number1 is the square of Number2");
    else
    {
        Console.WriteLine("Number1 is not the square of Number2");
    }
}
