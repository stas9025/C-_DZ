// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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



void Ordering(int[,] array)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for(int k = 0; k < arr.GetLength(1) - 1; k++)
      {
        if (arr[i, k] < arr[i, k + 1])
        {
          int tmp = arr[i, k+1];
          arr[i, k+1] = arr[i, k];
          arr[i, k] = tmp;
        }
      }
    }
  }
}

void PrintMatrix(int[,] array)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
  }
}
Ordering(arr);
PrintMatrix(arr);


