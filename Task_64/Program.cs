// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Clear();
Console.WriteLine("Введите число, обозначающее начало промежутка чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, обозначающее конец промежутка чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int count = m; count < n; count++) { Console.Write($"{count} "); }
Console.WriteLine();
