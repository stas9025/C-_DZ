// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Количество строк в матрице = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Количество столбцов в матрице = ");
int b = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double [a, b];


void PrintMass(double[,] array)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Random rnd = new Random();
      arr[i, j] = rnd.Next(1, 20);
      Console.Write(arr[i, j] + ", ");
    }
    Console.WriteLine();
  }
}
PrintMass(arr);



void Average(double[,] array)
{

  for(int i = 0; i < arr.GetLength(0); i++)
  {
    double sum = 0;
    double average = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      sum = sum + arr[j,i];
    }
    average = sum / b;
    Console.WriteLine("Среднее арифметическое столбца " + (i + 1) + " = " + average);
    
  }
}
Average(arr);