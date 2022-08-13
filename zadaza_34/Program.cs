// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] MyArrRndInd (int size)
{
  int[] array = new int[size];
  Random rnd = new Random();

  for(int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(100, 999);
  }
  return array;
}


void PrintArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
  {
    if(i==0) Console.Write("[");
    if(i < array.Length - 1)
    {
      Console.Write(array[i] + ", ");
    } 
    else Console.Write(array[i] + "]");
  }
}


void Zet(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    count++;
  }
  Console.Write($" -> {count}");
}

int[]array = MyArrRndInd(4);
PrintArray(array);
Zet(array);