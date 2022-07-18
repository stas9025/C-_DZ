// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите пожалуйста цифру дня недели!");

Console.Write("Ваша цифра = ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 1 || a > 7){
  Console.Write("Введите цифру больше 0, но не больше 7");
}
switch(a){
  case 1:
    Console.WriteLine("нет");
    break;
  case 2:
    Console.WriteLine("нет");
    break;
  case 3:
    Console.WriteLine("нет");
    break;
  case 4:
    Console.WriteLine("нет");
    break;
  case 5:
    Console.WriteLine("нет");
    break;
  case 6:
    Console.WriteLine("да");
    break;
  case 7:
    Console.WriteLine("да");
    break;
}