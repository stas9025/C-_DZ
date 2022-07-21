// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите пожалуйста число!");

Console.Write("Ваше число = ");
int a = Convert.ToInt32(Console.ReadLine());
int rez;
int i = 1;

while(i <= a){
  rez = i*i*i;
  Console.Write($"{rez}, ");
  i++;
}
