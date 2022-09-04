// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void Array(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11) + new Random().NextDouble();
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите параметр массива 'm' -  ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите параметр массива 'n' -  ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
Array(m, n);

// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, что такого элемента нет.

int[,] FillArray(int x, int y)
{
    int[,] array = new int[x, y];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int g = 0; g < array.GetLength(1); g++)
        {
            array[i, g] = new Random().Next(10, 100);
            Console.Write(array[i, g] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
void integer(int[,] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int g = 0; g < array.GetLength(1); g++)
        {
            if (array[i, g] == number)
            {
                Console.WriteLine("Число " + number + " Индексы числа :  " + (i + 1) + "," + (g + 1));
                count++;
            }
        }

    }
    if (count == 0)
    {
        Console.WriteLine(number + " -> число отсутствует.");
    }
}


Console.WriteLine("Введите параметр массива 'x' -  ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите параметр массива 'y' -  ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите целое число для поиска в массиве -  ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();
integer(FillArray(x, y), number);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите параметр массива 'x' -  ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите параметр массива 'y' -  ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine();
Sum(FillArray(x, y));


int[,] FillArray(int x, int y)
{
    int[,] array = new int[x, y];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int g = 0; g < array.GetLength(1); g++)
        {
            array[i, g] = new Random().Next(0, 10);
            Console.Write(array[i, g] + " ");
        }
        Console.WriteLine();
    }
    return array;
}


void Sum(int[,] array)
{
    Console.WriteLine();
    for (int g = 0; g < array.GetLength(1); g++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, g];
        }
        Console.WriteLine("Среднее арифметическое в столбце [" + (g+1) + "] =  " + sum/array.GetLength(0));
    }

}
