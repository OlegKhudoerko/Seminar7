// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int m = 3; // Количество строк
int n = 4; // Количество столбцов

if (rows+1 > m || columns +1> n) 
{
Console.WriteLine($"{rows}, {columns} -> такого числа в массиве нет");
return;
}

int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(100);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine($"{rows}, {columns} -> {matrix[rows, columns]}");
