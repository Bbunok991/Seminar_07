/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3*/

int InPut(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Array(int row, int column, int leftRange, int rightRange)
{
    Random rand = new Random();

    int[,] array = new int[row, column];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return array;
}

void PrintArray(int[,] arrayForPrint)
{
    double sum;
    double arithmetic_mean = 0;
    double[] array = new double[arrayForPrint.GetLength(0)];
    for(int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        sum = 0;
        for(int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayForPrint[i, j] + "\t");
            sum += arrayForPrint[i,j];
        }
        System.Console.WriteLine();
        arithmetic_mean = Math.Round((sum / arrayForPrint.GetLength(0)), 1);
        array[i] = arithmetic_mean;
    }
    System.Console.WriteLine("Arithmetic mean of each column: " + string.Join("; ", array) + ".");
}

int row = InPut("Enter a row: ");
int column = InPut("Enter a column: ");
int leftRange = InPut("Enter a left range: ");
int rightRange = InPut("Enter a right range: ");
int[,] matrix = Array(row, column, leftRange, rightRange);

PrintArray(matrix);
