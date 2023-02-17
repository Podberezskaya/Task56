//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(0,11);
    }
  }
}
void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
  }
}
void Release(int[,] matrix)
{
    int min_row = 0;
    int minsum_row = 0;
    int sum_row = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        min_row += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sum_row += matrix[i, j];
        if (sum_row < min_row)
        {
            min_row = sum_row;
            minsum_row = i;
        }
        sum_row = 0;
    }
    Console.Write($"{minsum_row + 1} строка");
}
Console.Write ("Введите размер массива: ");
int [] size = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
int[,] matrix = new int[size [0], size[1]];
Console.WriteLine("Начальный массив: ");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Cтрока с наименьшей суммой элементов: ");
Release(matrix);
