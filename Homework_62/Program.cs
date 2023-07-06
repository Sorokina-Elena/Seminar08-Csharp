/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.Clear();

int[,] CreatArray(int row, int col)
{
int[,] array = new int[row, col];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= row*col)
{
    array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < col - 1)
      j++;
    else if (i < j && i + j >= row - 1)
      i++;
    else if (i >= j && i + j > col - 1)
      j--;
    else
      i--;
    }
    return array;
}

void PrintArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int [,] array = CreatArray(4,4);
PrintArray(array);
  


    



