// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumOfNumbers(int M, int N)
{
    if (M == N) return M;
    return M + SumOfNumbers(M + 1, N);
}

int M = EnterData("Введите первое число: ");
int N = EnterData("Введите второе число: ");
Console.WriteLine(SumOfNumbers(M, N));