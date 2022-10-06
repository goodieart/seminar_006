namespace Lib;
public class Helper
{
    public static int ArrayZeroSum(string[] inArray)
    {
        int result = 0;
        foreach (string element in inArray)
        {
            if (int.Parse(element) > 0) result++;
        }
        return result;
    }
    public static float[] LineIntersection(float b1, float k1, float b2, float k2)
    {
        if (k1 == k2) return null!;

        float[] result = new float[2];

        result[0] = (b2 - b1) / (k1 - k2);
        result[1] = k1 * result[0] + b1;

        return result;
    }
    public static string[] GetUserInput(string separator = " ")
    {
        return Console.ReadLine()!.Split(separator, StringSplitOptions.RemoveEmptyEntries);
    }
}
