// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 3; // Количество строк
int n = 4; // Количество столбцов
int[,] matrix = new int[m, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(31);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.Write("Среднее арифметическое каждого столбца: ");

for (int i = 0; i < matrix.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sum += matrix[j, i];
    }
    Console.Write($"{Math.Round((sum / m), 1)}; ");
}