// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] MyArr = {3.5, 7.1, 22.9, 2.3, 78.5};
{
  double min = double.MaxValue;
  double max = double.MinValue;
  for (int i = 0; i < MyArr.Length; i++)
  {
    if (MyArr[i] < min)
    {
      min = MyArr[i];
    } 
    if (MyArr[i] > max) 
    {
      max = MyArr[i];
    }
  }
  Console.WriteLine($"Максимальное значение = {max}, минимальное значение =  {min}");
  Console.Write($"Разница между максимальным и минимальным значением = {max - min}");
}


/*void PrintArray(int[] array)
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
}*/


/*void Zet(double[] array)
{
  double min = 0;
  double max = 0;
  for (int i = 0; i < MyArr.Length; i++)
  {
    if (min > i) min = i;
    if (max < i) max = i;
  }
  Console.Write($"Максимальное значение = {max}, минимальное значение =  {min}");
  Console.Write($"Разница между максимальным и минимальным значением = {max - min}");
}*/

//MyArr();
//PrintArray(array);
//Zet(MyArr);