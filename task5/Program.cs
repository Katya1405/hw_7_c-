// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

Console.WriteLine("Матрица, заданная рандомом");
FillRandomMatrix(matrix, 0, 101);
PrintMatrix(matrix);

double[] sum = new double[n];

for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        sum[j] += matrix[i, j];
}

Console.WriteLine("Среднее арифметическое столбцов: ");
for (int j = 0; j < matrix.GetLength(1); j++)
    Console.Write(sum[j] / m + " ");