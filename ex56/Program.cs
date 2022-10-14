// //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.




Console.Write("Введите размерность квадратной матрицы m=");
int m = int.Parse(Console.ReadLine()!);
int[,] myMatrix = CreateIntMatrix(m, m);
PrintMatrix(myMatrix);

FindMinSumRow(myMatrix);

int[,] CreateIntMatrix(int m, int n)
{
    int[,] resultMatrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.Next(5);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void FindMinSumRow(int[,] matrix)
{
    int minSumRow = 1;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (i == 0)
        {
            minSum = sum;
        }
        else
        if (sum < minSum)
        {
            minSumRow = i + 1;
            minSum = sum;
        }
    }
    Console.WriteLine("Строка с минимальной суммой = " + minSumRow);
}
