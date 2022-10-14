// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// //Например, задан массив:
// //1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите размерность массива m=");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите размерность массива n=");
int n = int.Parse(Console.ReadLine()!);
int[,] myMatrix = CreateIntMatrix(m, n);
PrintMatrix(myMatrix);

Console.WriteLine("Упорядочим все строки");
OrderRowsMatrix(myMatrix);
PrintMatrix(myMatrix);


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

void OrderRowsMatrix(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        int indx;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            indx = i; 
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                if (matrix[k, j] > matrix[k, indx])
                {
                    indx = j;
                }
            }
            if (matrix[k, indx] == matrix[k, i])
                continue;
            int temp = matrix[k, i]; 
            matrix[k, i] = matrix[k, indx];
            matrix[k, indx] = temp;
        }
    }
}
