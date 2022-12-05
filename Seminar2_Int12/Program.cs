// Задача №12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число
//кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//● 34, 5 -> не кратно, остаток 4
//● 16, 4 -> кратно 

Console.Write("Введите number 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите number 2: ");
int number2 = int.Parse(Console.ReadLine());

int aliquot = number1 % number2;

if (aliquot == 0)
{
    Console.WriteLine("без остатка");
}
else 
{
     Console.WriteLine($"не кратно, {aliquot}");
}