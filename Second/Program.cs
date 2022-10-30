// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Задайте значение N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Задайте значение M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine(RecursSum(n, m));

int RecursSum(int n, int m)
{
  if (n == m)
  {
  return n;
  }
return m + RecursSum(n, m - 1);
}