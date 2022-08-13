// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6]-> 0

int[] MyArrRndInd(int size)
{
  int[] array = new int[size];
  Random rnd = new Random();

  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(-100, 100);
  }
  return array;
}


void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (i == 0) Console.Write("[");
    if (i < array.Length - 1)
    {
      Console.Write(array[i] + ", ");
    }
    else Console.Write(array[i] + "]");
  }
}


void Zet(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 != 0)
      sum += array[i];
  }
  Console.Write($" -> {sum}");
}

int[] array = MyArrRndInd(4);
PrintArray(array);
Zet(array);