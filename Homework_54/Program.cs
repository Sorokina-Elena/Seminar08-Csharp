/*
Задача 54
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Clear();

int[,] CreatArray(int row, int col, int min, int max)
{
    Random rand = new Random();
    int[,] array = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.Next(min,max+1);
        }
    }
    return array;
}

int [,] CreatNewArray(int [,] myArray)
{
    int m = myArray.GetLength(0);
    int n = myArray.GetLength(1);
    int [,] creatNewArray = new int [m, n];
    {
        for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (m = 0; m < myArray.GetLength(1) - 1; m++)
            {
                if (myArray[i, m] < myArray[i, m + 1])
                {
                    int temp = myArray[i, m + 1];
                    myArray[i, m + 1] = myArray[i, m];
                    myArray[i, m] = temp;
                }
            }  
        }
    }
    return myArray;    
} 
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


int [,] array = CreatArray(3, 4, -10, 10);
PrintArray(array);
Console.WriteLine();
CreatNewArray(array);
PrintArray(array);




 


