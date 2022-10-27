// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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

Console.WriteLine("Задайте количество строк в матрице");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте количество столбцов в матрице");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m, n];

Console.WriteLine("Заданная рандомом матрица");
FillRandomMatrix(matrix, -10, 11);
PrintMatrix(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
            matrix[i, j] = (int)Math.Pow(matrix[i, j], 2);
    }
}

Console.WriteLine("Итоговая матрица");
PrintMatrix(matrix);