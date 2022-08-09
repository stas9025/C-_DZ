// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452-> 11

// 82-> 10

// 9012-> 12

Console.WriteLine("Введите пожалуйста число!");
int a = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
  int sum = 0;

  while(a != 0)
  {
    sum += a % 10;
    a = a / 10; 
  }
  return sum;

}
int res = Sum(a);
Console.WriteLine($"Сумма всех чисел = {res}");