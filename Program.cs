// Задача 2
/*
Console.WriteLine("Введите 1-е число ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2-е число ");
int number2 = int.Parse(Console.ReadLine());
int max = number1;

if (number1 < number2) max = number2;
{
    Console.WriteLine($"Максимальное чило = {max}");
}
*/

// Задача 4
/*
Console.WriteLine("Введите 1-е число");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2-е число");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 3-е число");
int number3 = int.Parse(Console.ReadLine());

int max = number1;

if (number1 < number2) max = number2;

if (number2 < number3) max = number3;
{
    Console.WriteLine($"Максимальное число равно = {max}");
}

*/

// Задача 6
/*
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
if(n % 2 == 0)
{
Console.WriteLine("Четное");
}
if(n % 2 != 0)
{
Console.WriteLine("НЕ четное");
}
*/

// Задача 8

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
 int a = 0;
while (a < n)
{
    if (n % 2 == 0)
    {
        a = a + 2;
        Console.Write($"{a}, ");
    }
       if (n % 2 != 0)
    {
        n = n - 1;
        a = a + 2;
        Console.Write($"{a}, ");
    }
}