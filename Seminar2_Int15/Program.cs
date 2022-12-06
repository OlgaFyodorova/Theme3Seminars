// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли 
// этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Enter day number : ");
string EnterDay = Console.ReadLine();
int day = Convert.ToInt32(EnterDay);
string WeekDay = "Monday";

if ((day > 7) || (day < 1))
{
    Console.WriteLine("Day of the week is not found, please enter a valid day");
    return;
}

if ((day == 6) || (day == 7))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}