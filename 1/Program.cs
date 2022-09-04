// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100,1000);
String str = num.ToString();
Console.WriteLine(num);
Console.WriteLine("Выводим второе число " + str[1]);

// Второе решение

int[] array = new int[] {7, 8, 2};
Console.WriteLine("Выводим второе число  " + array[1]);

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число число : ");
string str = Console.ReadLine();
if (str.Length>=3)
{
    Console.WriteLine(str[2]);
}
else 
{
    Console.WriteLine("Третьей цифры нет.");
}

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int[] array = new int[] {1,2,3,4,5,6,7};

Console.WriteLine("Введите число :   ");
int num = int.Parse(Console.ReadLine()); 


if (num >= array[5]) 
{
Console.WriteLine("Выходной");
}
else if (num >= array[6])
{Console.WriteLine("Выходной");
}
else
{
Console.WriteLine("Рабочий день");
}
