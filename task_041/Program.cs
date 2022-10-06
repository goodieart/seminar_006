using Lib;
using static System.Console;

Write("Введите ряд чисел через пробел: ");
string[] input = Helper.GetUserInput();
WriteLine($"Количество положительных чисел = {Helper.ArrayZeroSum(input)}");