/* Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ
ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.

5
0
7
8
-2
-2 -> 2

5
1
-7
567
89
223-> 3 */

Console.Clear();
Console.Write("Сколько чисел будете вводить? ");
int a = Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write($"Количество чисел больше 0 -> {InputNum(a)}");


int InputNum(int a)
{   
    int summ = 0;
    for (int i = 1; i <= a; i++)
    {
        int b = int.Parse(Console.ReadLine()!);
        if (b > 0)
            summ++;
    }
    return summ;
}   