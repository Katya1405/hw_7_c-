// Показать двумерный массив размером m×n заполненный вещественными числами

void FillMatrix(double[,] matrix)
{
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
            matrix[i, j] = new Random().NextDouble()*100;
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

Console.WriteLine("Задайте количество строк в матрице");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте количество столбцов в матрице");
int n = int.Parse(Console.ReadLine() ?? "0");

double[,] matrix = new double[m,n];
FillMatrix(matrix);
PrintMatrix(matrix);