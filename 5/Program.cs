// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа:  ");
int c = int.Parse(Console.ReadLine());
Console.Write("Массив:  ");

int[] fillarray(int capacity)
{
    int[] array = new int[capacity];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
        Console.Write(array[i] + " ");
    }
    return array;
}

int[] array = fillarray(c);

int counter(int[] array)
{
    int x = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            i++;
            x++;
        }
        else
        {
            i++;
        }
    }
    return x;
}
int count = counter(array);
Console.WriteLine();
Console.WriteLine("Количество чисел больше 0 -  " + count);


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void tochka(double k1, double b1, double k2, double b2)
{
    double x;
    double y;
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine("x=" + x + " y=" + y);
}

Console.WriteLine("Введите координату (b1)");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату (k1)");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату (b2)");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату (k2)");
double k2 = double.Parse(Console.ReadLine());
tochka(k1, b1, k2, b2);