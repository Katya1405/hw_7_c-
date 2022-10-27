// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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

int m = new Random().Next(1, 5);
int n = new Random().Next(1, 5);
int[,] matrix = new int[m, n];

FillRandomMatrix(matrix, 0, 51);
PrintMatrix(matrix);

Console.WriteLine("Введите число, которое будем проверять: ");
int value = int.Parse(Console.ReadLine() ?? "0");

int numberStr = 0;
int numberCol = 0;
bool x = false;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == value)
        {
            x = true;
            numberStr = i;
            numberCol = j;
        }
        else
            x = false;
    }
}

if (x == true)
    Console.WriteLine($"Позиции числа {value} = строка {numberStr + 1} и столбец {numberCol + 1}");
else
    Console.WriteLine($"{x} - Такого числа в массиве нет");