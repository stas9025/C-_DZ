// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

Console.Write("Промежуток от M = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("ДО N = ");
int n = Convert.ToInt32(Console.ReadLine());

static void Recursion(int m, int n)
{
  int sum = 0;
  for(int i = m; i <= n; i++)
  {
    sum = sum + i;
  }
  Console.WriteLine($"Сумма промежутка = {sum}");
}
Recursion(m, n);