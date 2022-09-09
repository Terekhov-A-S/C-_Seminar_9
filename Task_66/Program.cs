// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
Console.WriteLine("Введите число, обозначающее начало промежутка чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, обозначающее конец промежутка чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int count = m; count <= n; count++) { sum = sum + count; }
Console.Write($"{sum}");
Console.WriteLine();
