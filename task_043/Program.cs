using Lib;
using static System.Console;

Write("Введите b1, k1, b2, k2 (через пробел): ");

string[] input = Helper.GetUserInput();
float[] arg = new float[4];
for (int i = 0; i < input.Length; i++) arg[i] = float.Parse(input[i]);
var intersection = Helper.LineIntersection(arg[0], arg[1], arg[2], arg[3]);

WriteLine($"Точка пересечения (x, y): {(intersection != null ? string.Join(", ", intersection) : "отсутствует (или \u221E)")}");