using static System.Console;

Write("Введите ряд чисел через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine($"Количество положительных чисел = {ArrayZeroSum(parameters)}");

int ArrayZeroSum(string[] inArray)
{
    int result = 0;
    foreach (string element in inArray)
    {
        if (int.Parse(element) > 0) result++;
    }
    return result;
}