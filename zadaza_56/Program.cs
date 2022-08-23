// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Количество строк в матрице = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Количество столбцов в матрице = ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[a, b];


void PrintMass(int[,] array)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Random rnd = new Random();
      arr[i, j] = rnd.Next(1, 20);
      Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}
PrintMass(arr);



void MinSum(int[,] array)
{
  int sum = 0;  int sum1 = 0;  int sum2 = 0; int row = 0;
  PrintMass(arr);
  for (int i = 0; i < arr.GetLength(0); i++)
  {
     sum2 = 0;
     for(int j = 0; j < arr.GetLength(1); j++)
     {
        sum2 = sum2 + arr[i,j];
     }
      if(sum2 < sum1)
      {
        sum = sum2;
        row=i;
      }
      sum1 = sum2;
  }
  Console.WriteLine(sum);
  Console.WriteLine(row);
  Console.ReadKey();
}

MinSum(arr);
