// Написать программу, которая обменивает элементы первой строки и последней строки

void FillRandomMatrix(int[,] matrix, int min, int max)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(min, max);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

Console.Write("Задайте количество строк в матрице: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Задайте количество столбцов в матрице: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];

Console.WriteLine("Исходная матрица");
FillRandomMatrix(matrix, 0, 51);
PrintMatrix(matrix);

int temp = 0;
int i = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    temp = matrix[i, j];
    matrix[i, j] = matrix[m - 1, j];
    matrix[m - 1, j] = temp;
}

Console.WriteLine();
Console.WriteLine("Результат");
PrintMatrix(matrix);