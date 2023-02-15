/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

System.Console.WriteLine("Введите число M > 0:" );
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N > 0:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана двух чисел {m} и {n} = {AkkermansFunction(m, n)}");

int AkkermansFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AkkermansFunction(m - 1, 1);
    else
        return AkkermansFunction(m - 1, AkkermansFunction(m, n - 1));
}