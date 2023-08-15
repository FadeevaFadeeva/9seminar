// ������ 64: ������� �������� N. �������� ���������, ������� ������� ��� ����������� ����� 
// � ���������� �� N �� 1. ��������� � ������� ��������.

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
    Console.WriteLine("������ ������������� �����!");
    return;
}
Console.WriteLine(NaturalNumber(n, 1));



// ������ 66: ������� �������� M � N. �������� ���������, ������� ����� ����� ����������� ��������� 
// � ���������� �� M �� N.

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