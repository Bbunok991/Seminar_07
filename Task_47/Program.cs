/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int InPut(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] Array(int row, int column, int leftRange, int rightRange)
{
    Random rand = new Random();

    double[,] array = new double[row, column];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
        }
    }
    return array;
}

void PrintArray(double[,] arrayForPrint)
{
    for(int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for(int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int row = InPut("Enter a row: ");
int column = InPut("Enter a column: ");
int leftRange = InPut("Enter a left range: ");
int rightRange = InPut("Enter a right range: ");
double[,] matrix = Array(row, column, leftRange, rightRange);

PrintArray(matrix);