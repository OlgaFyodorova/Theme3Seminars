﻿//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.WriteLine("Enter day number : ");
string EnterDay = Console.ReadLine();
int day = Convert.ToInt32(EnterDay);
string WeekDay = "Monday";

if (day == 1 ) WeekDay = "Monday";
if (day == 2 ) WeekDay = "Tuesday";
if (day == 3 ) WeekDay = "Wednesday";
if (day == 4 ) WeekDay = "Thursday";
if (day == 5 ) WeekDay = "Friday";
if (day == 6 ) WeekDay = "Saturday";
if (day == 7 ) WeekDay = "Sunday";

if ((day > 7) || (day < 1))
{
    Console.WriteLine("Day of the week is not found, please enter a valid day");
    return;
}

Console.WriteLine(WeekDay);