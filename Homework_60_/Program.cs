/*
Задача 60. ...Сформируйте двухмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2
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
            array[i,j] = i + j;       
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




int [,] array = CreatArray(2, 2, 10, 100);
PrintArray(array);
