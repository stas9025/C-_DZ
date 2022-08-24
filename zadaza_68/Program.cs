// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2->A(m, n) = 29

Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());

static int Akk(int m, int n)
{
  if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
  if (n == 0) return m + 1;
  if (m == 0) return Akk(n - 1, m);
  return Akk(n - 1, Akk(n, m - 1));
  
}
Akk(m,n);