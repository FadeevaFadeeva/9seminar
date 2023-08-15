// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int NaturalNumber(int n, int m)
{
    if (n == m) return n;
    else Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int n = Prompt("Input N: ");
if (n < 1)
{
    Console.WriteLine("Ввдите положительное число!");
    return;
}
Console.WriteLine(NaturalNumber(n, 1));



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumOfElements(int n, int m)
{
    if (n == m) return n;
    else return SumOfElements(n + 1, m) + n;
}

int n = Prompt("Input N: ");
int m = Prompt("Input M: ");

Console.WriteLine(SumOfElements(n, m));