/* Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();
Console.WriteLine("Введите b1, k1 и b2, k2 через пробел ");
string input = Console.ReadLine()!;
double[] variables = ParseToArray(input);

double b1 = variables[0]; double b2 = variables[2];
double k2 = variables[3]; double k1 = variables[1];

double resK = k1 - k2;
double resB = b2 - b1;
double x = resB / resK;
double y = k1 * x + b1;

Console.WriteLine($"({x}, {y})");

double[] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    double[] result = new double[stringArray.Length];
 
    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = double.Parse(stringArray[i]);
    }
 
    return result;
}