// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7->такого числа в массиве нет

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
      arr[i,j] = rnd.Next(1, 20);
      Console.Write(arr[i, j] + ", ");
    }
    Console.WriteLine();
    
  }
}
PrintMass(arr);

Console.Write("Позиция элемента в строке = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Позиция элемента в столбце = ");
int n = Convert.ToInt32(Console.ReadLine());

void Position(int[,] array)
{

  if (m > a && n > b)
  {
    Console.Write("такого числа в матрице нет");
  }
  else
  {
    object rez = arr.GetValue(m, n);
    Console.WriteLine(rez);
  }
  
}
Position(arr);