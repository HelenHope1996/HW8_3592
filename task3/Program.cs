/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

//задать матрицу и заполнить ее числами
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j ] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

//распечатать матрицу
void PrintMatrix(int[,] matrix)
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


// нахождение произвениея 

void Multiply(int[,] firstMartrix, int[,] secomdMartrix, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int summ = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                summ += firstMartrix[i,k] * secomdMartrix[k,j];
            }
            result[i,j] = summ;
        }
    }
}


int m = GetNumber("Введите количество строк 1-й матрицы:");
int n = GetNumber("Введите количество столбцов 1-й матрицы (и строк 2-й)");
int p = GetNumber("Введите число столбцов 2-й матрицы: ");

int[,] firstMatrix = GetMatrix(m,n);
Console.WriteLine($"Первая матрица:");
PrintMatrix(firstMatrix);

int[,] secondMatrix = GetMatrix(n,p);
Console.WriteLine($"Вторая матрица:");
PrintMatrix(secondMatrix);

int[,] result = new int[m, p];
Multiply(firstMatrix, secondMatrix, result);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintMatrix(result);



