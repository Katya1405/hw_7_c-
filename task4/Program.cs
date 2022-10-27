// В матрице чисел найти сумму элементов главной диагонали

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

Console.WriteLine("Исходная матрица");
FillRandomMatrix(matrix, -10, 11);
PrintMatrix(matrix);

int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == j)
            sum += matrix[i, j];
    }
}

Console.WriteLine($"Сумма элементов главной диагонали матрицы = {sum}");
