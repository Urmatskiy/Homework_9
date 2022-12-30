// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string PrintNumbers(int N)
{
    if (N == 1) return "1";
    return $"{N}, " + PrintNumbers(N - 1);
}

int num = EnterData("Введите число: ");
Console.WriteLine(PrintNumbers(num));