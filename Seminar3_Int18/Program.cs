// Задача №18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).


Console.Write("Введите номер четверти от 1 до 4: ");
int num  = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("X > 0, y > 0");
}
else if (num == 2)
{
    Console.WriteLine("X < 0, y > 0");
}
else if (num == 3)
{
    Console.WriteLine("X < 0, y < 0");
}
else if (num == 4)
{
    Console.WriteLine("X > 0, y < 0");
}
else Console.WriteLine("некорректное число");