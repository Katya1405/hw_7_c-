// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

Console.WriteLine("Исходная матрица:");
FillRandomMatrix(matrix, 0, 51);
PrintMatrix(matrix);

int[] sum = new int[m];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        sum[i] += matrix[i, j];
}

int MinValue = sum[0];
int index = 0;

for (int i = 0; i < sum.Length; i++)
{
    if (sum[i] < MinValue)
    {
        MinValue = sum[i];
        index = i;
    }
}

Console.WriteLine($"Минимальная сумма по строкам = {MinValue} и находится в {index + 1} строке");





