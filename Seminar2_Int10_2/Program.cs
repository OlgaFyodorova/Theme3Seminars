// //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Enter number : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int secondNumber = (num / 10) % 10; //789/10= 78 %10=8
    Console.WriteLine($"Вторая цифра в числе {num} -> {secondNumber}");
}
else
    Console.WriteLine ($"Число {num} не трёхзначное");