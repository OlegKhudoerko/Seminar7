// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3; // Количество строк
int n = 4; // Количество столбцов

double[,] matrix = new double[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = Math.Round(((new Random().NextDouble() * 2 - 1) * 10), 1);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

