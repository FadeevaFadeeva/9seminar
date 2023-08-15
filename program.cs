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