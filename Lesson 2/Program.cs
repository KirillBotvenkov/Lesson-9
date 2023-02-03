//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int Promt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNaturalElements(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма натуральных элементов в промежутке от M до N равна: {sum}");
        return;
    }
    PrintNaturalElements(m, n - 1, sum);
}

int m = Promt("Введите натуральное число M:");
int n = Promt("Введите натуральное число N:");
PrintNaturalElements(m,n,0);