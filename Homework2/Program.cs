/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

//Решение:

Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine());

while (number > 99 | number < 1000)
{
    if (number < 100 | number > 999)
    {
        Console.WriteLine("Это не трехзначное число");
        break;
    }

    int secondNumber = (number % 100 - number % 10) / 10;
    Console.WriteLine(secondNumber);
    break;
}




/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

//Решение:

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

bool InvalidNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Нет третей цифры");
        return false;
    }
    return true;
}

int TreeNumber(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}
if (InvalidNumber(number))
{
    Console.WriteLine(TreeNumber(number));
}




/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

//Решение:

Console.WriteLine("Выведите число обозначающее день недели:");
int number = int.Parse(Console.ReadLine());

void DayWeek(int number)
{
    if (number == 6 | number == 7)
    {
        Console.WriteLine("Да, это выходной");
    }
    else if (number < 1 | number > 7)
    {
        Console.WriteLine("Некоректное число");
    }
    else
    {
        Console.WriteLine("Нет, это не выходной");
    }
}
DayWeek(number);
