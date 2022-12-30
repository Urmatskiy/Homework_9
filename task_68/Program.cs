// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Akerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akerman(m - 1, 1);
    return Akerman(m - 1, Akerman(m, n - 1));
}

int M = EnterData("Введите первое число: ");
int N = EnterData("Введите второе число: ");

Console.WriteLine(Akerman(M, N));