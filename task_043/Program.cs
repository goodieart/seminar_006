using static System.Console;

Write("Введите b1, k1, b2, k2 (через пробел): ");

string[] input = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
float[] arg = new float[4];
for (int i = 0; i < input.Length; i++) arg[i] = float.Parse(input[i]);
var intersection = LineIntersection(arg[0], arg[1], arg[2], arg[3]);

WriteLine($"Точка пересечения (x, y): {(intersection != null ? string.Join(", ", intersection) : "отсутствует (или \u221E)")}");

float[] LineIntersection(float b1, float k1, float b2, float k2)
{
    if (k1 == k2) return null!;

    float[] result = new float[2];

    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;

    return result;
}