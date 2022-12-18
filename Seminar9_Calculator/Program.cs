//Калькулятор Lite Ver.

double firstNum;
double secondNum;
string operation;
double result;


Console.WriteLine("Первое число: ");
firstNum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Действие %, *, /, +, - : ");
operation = Convert.ToString(Console.ReadLine());

Console.WriteLine("Второе число: ");
secondNum = Convert.ToDouble(Console.ReadLine());

if (operation == "+")
{
    result = firstNum + secondNum;
    Console.WriteLine("Результат: " + result);
}

if (operation == "-")
{
    result = firstNum - secondNum;
    Console.WriteLine("Результат: " + result);
}

if (operation == "*")
{
    result = firstNum * secondNum;
    Console.WriteLine("Результат: " + result);
}

if (operation == "/")
{
    result = firstNum / secondNum;
    Console.WriteLine("Результат: " + result);
}