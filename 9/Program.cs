// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int m = 1;
int n = 10;
int NaturalТnumber(int m, int n)
{
    if (m > n && n > 0)
    {
        return NaturalТnumber(n,m);
    }
    else if (m > 0 && m < n)
    {
        System.Console.Write(m + " ");
        return NaturalТnumber(m + 1, n);
    }
    else
    {
        return m;
    }
}
NaturalТnumber(m, n);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = 1;
int n = 15;
int NaturalТnumber(int m, int n)
{
    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum +=i;
    }
    return sum;
}
System.Console.WriteLine(NaturalТnumber(m, n));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = 2;
int n = 3;
int FunctionAkkerman(int m, int n)
{
  if (m == 0)
    return m + 1;
  else
    if ((m != 0) && (m == 0))
      return FunctionAkkerman(m - 1, 1);
    else
      return FunctionAkkerman(m - 1, FunctionAkkerman(m, m - 1));
}
Console.WriteLine(FunctionAkkerman(m,n));