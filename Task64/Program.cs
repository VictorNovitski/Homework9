/*
Задача 64: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
System.Console.WriteLine("Введите число n > 0: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Printnumbers(n, 1));
string Printnumbers(int start, int end)
{
   if(start == end)
   {
        return start.ToString();
   }
   return (start + " " + Printnumbers(start - 1, end)); 
}