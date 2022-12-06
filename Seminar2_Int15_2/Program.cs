// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли 
// этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Enter dayWeek : ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

switch (dayWeek)
{
    case 1:
        Console.WriteLine("Понедельник - НЕТ");
        break;
    case 2:
        Console.WriteLine("Вторник - НЕТ");
        break;
    case 3:
        Console.WriteLine("Среда - НЕТ");
        break;
    case 4:
        Console.WriteLine("Четверг - НЕТ");
        break;
    case 5:
        Console.WriteLine("Пятница - НЕТ");
        break;
    case 6:
        Console.WriteLine("Суббота - ДА");
        break;
    case 7:
        Console.WriteLine("Воскресенье - ДА");
        break;
    default:
        Console.WriteLine("Некорректный номер дня недели");
        break;
}

