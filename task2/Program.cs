/*
 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
 наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка
*/

// задать массив и заполнить ее числами
void FillArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j ] = new Random().Next(1,10);
        }
    }
}

// печать массива
void PrintArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// нахождение суммы 
int Summ(int[,] matrix, int i)
{
  int sumLine =matrix[i,0];
  int summ = 0;
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    
    summ += matrix[i,j];
  }
  return summ;
}

//поиск минимального значения
void Min(int[,] matrix)
{
    int minSumm = 0;
    int summLine = Summ(matrix, 0);
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int tempSummLine = Summ(matrix, i);
        if (summLine > tempSummLine)
        {
            summLine = tempSummLine;
            minSumm = i;
        }
    }

    Console.WriteLine($"\n{minSumm+1}");
}

int[,] matrix = new int[3,4];
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine($"\nСтрока с наименьшей суммой: ");
Min(matrix);