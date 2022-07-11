Console.WriteLine("Введите пожалуйста три числа!");

Console.Write("Число а = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Число b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Число c = ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
  Console.WriteLine($"max = {a}");
}
else if (b > a && b > c)
{
  Console.WriteLine($"max = {b}");
}
else
{
  Console.WriteLine($"max = {c}");
}
