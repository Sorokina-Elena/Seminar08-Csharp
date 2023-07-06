/*
Задача 58 
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();

int[,] creatArray(int row, int col, int min, int max)
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

int [,] MultiplicationArray(int[,] array1, int[,] array2){
    int row1 = array1.GetLength(0);
    int col2 = array2.GetLength(1);

    int [,] newArray = new int [array1.GetLength(0),array2.GetLength(1)]; 
    int row = array1.GetLength(0);

    for (int i = 0; i < row1; i++)
    {
        for (int n = 0; n < col2; n++)
            {
                for (int k = 0; k < row; k++)
                {
                    newArray[i, n] += array1[i, k] * array2[k, n];
                }
            } 
    }
    return(newArray);
}
    


int [,] array1 = creatArray(2, 2, 0, 10);
PrintArray(array1);
Console.WriteLine();
int [,] array2 = creatArray(2, 2, 0, 10);
PrintArray(array2);
Console.WriteLine();
int [,] newArray = MultiplicationArray(array1, array2);
PrintArray(newArray);


