/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int InPut(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Array(int row, int column, int leftRange, int rightRange, int position1, int position2)
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
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    if(position1 > row || position2 > column) System.Console.WriteLine($"{position1}{position2} -> there is no such number in the array.");
    else System.Console.WriteLine(array[position1, position2]);
}

int row = InPut("Enter a row: ");
int column = InPut("Enter a column: ");
int leftRange = InPut("Enter a left range: ");
int rightRange = InPut("Enter a right range: ");
int position1 = InPut("Enter the first position: ");
int position2 = InPut("Enter the second position: ");
Array(row, column, leftRange, rightRange, position1, position2);

