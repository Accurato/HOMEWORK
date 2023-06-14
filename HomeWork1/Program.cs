/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

//Решение:


Console.WriteLine("Введите 2 числа:");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int max = 1;
int min = 0;

if (a > b)
{
    max = a;
    min = b;
    Console.Write("Большее число: ");
    Console.WriteLine(max);
    Console.Write("Меньшее число: ");
    Console.Write(min);
}
if (b > a)
{
    max = b;
    min = a;
    Console.Write("Большее число: ");
    Console.WriteLine(max);
    Console.Write("Меньшее число: ");
    Console.Write(min);
}





/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

//Решение:


Console.WriteLine("Введите 3 числа:");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine(max);





/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

//Решение:


Console.WriteLine("Введите число:");

int number = int.Parse(Console.ReadLine());

int num = number % 2;

if (num == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}





/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

//Решение:

int numberN = int.Parse(Console.ReadLine());
int i = 2;

if (numberN > 1)
{
    while (i <= numberN)
    {
        Console.WriteLine(i);
        i += 2;
    }
}
