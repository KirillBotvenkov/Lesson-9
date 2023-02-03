//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Задайте число: ");
int n = int.Parse(Console.ReadLine());

int NaturalNumber(int num)
{
    if (num != 0)
    {
        Console.Write($"{num:d2} ");
        NaturalNumber(num-1);
    }
    return num;
}
NaturalNumber(n);