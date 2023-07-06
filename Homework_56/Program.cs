/*
Задача 56
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int [,] findArithmeticMean (int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int minSum =0;
    for (int i = 0; i < i+1 && i < row; i++)
    {
        
        int sum = 0;
        for (int j = 0; j < col; j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
        }
        Console.WriteLine($"Сумма строки {i+1} равна {sum}");
        Console.WriteLine();  
    }
    Console.WriteLine($"Сумма строки равна {minSum}");
    return array;
}

 int [,] array = creatArray(6, 6, -10, 10);
 PrintArray(array);
 Console.WriteLine();
 findArithmeticMean(array);
