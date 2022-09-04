// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите значение массива 'x' -  ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите значение массива 'y' -  ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[x, y];


int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}


void BubbleSort(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {  
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] <= array[i, k + 1])
                {
                    int x = array[i,k];
                    array[i, k] = array[i,k+1];
                    array[i, k+1] = x;
                }
            }
        Console.Write(array[i,j] + " ");
        }
    System.Console.WriteLine();
    }
}

BubbleSort(FillArray(array));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите значение массива 'x' -  ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите значение массива 'y' -  ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[x, y];


int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

void MinString(int[,] array)
{
    Console.WriteLine();
    int count = 0;
    double min = 100;
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < min)
        {
            min = sum;
            count = i;
            sum = 0;
        }
    }
    System.Console.WriteLine("Строка с наименьшей суммой элементов - " + (count + 1));

}
FillArray(array);
MinString(array);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите значение массива 'x' -  ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите значение массива 'y' -  ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array0 = new int[x, y];
int[,] array1 = new int[x, y];

int[,] FillArray(int[,] array0)
{
    for (int i = 0; i < array0.GetLength(0); i++)
    {
        for (int j = 0; j < array0.GetLength(1); j++)
        {
            array0[i, j] = new Random().Next(0, 10);
            Console.Write(array0[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array0;
}

void Produkt(int[,] array0, int[,] array1)
{
    int[,] matrix = new int[array0.GetLength(0), array0.GetLength(1)];
    for (int i = 0; i < array0.GetLength(0); i++)
    {
        for (int j = 0; j < array0.GetLength(1); j++)
        {
            matrix[i, j] = array0[i,j] * array1[i,j];
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Первый массив :");
FillArray(array0);
System.Console.WriteLine();
System.Console.WriteLine("Второй массив :");
FillArray(array1);
System.Console.WriteLine();
System.Console.WriteLine("Произведение массивов :");
Produkt(array0, array1);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array3D = new int[2, 2, 2];

int[,,] FillArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = new Random().Next(0, 10);
                Console.Write(array3D[i, j, k] + "(" + i + "," + j + "," + k + ") ");
            }
            Console.WriteLine();
        }
    }
    return array3D;
}
FillArray(array3D);

