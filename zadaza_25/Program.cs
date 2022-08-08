// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4-> 16

Console.WriteLine("Введите пожалуйста число A!");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите пожалуйста степень B!");
int b = Convert.ToInt32(Console.ReadLine());

int rez = 1;

for (int i = 0; i < b; i++)
{
  rez = rez * a;
}
Console.Write($"-> {rez}");
return 0;
