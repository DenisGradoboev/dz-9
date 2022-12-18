//Задача 68: Напишите программу вычисления функции 
//Аккермана с помощью рекурсии. Даны два 
//неотрицательных числа m и n.
Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFun(m,n);
Console.WriteLine(AkkermanFun(m,n));

int AkkermanFun(int m, int n)
{
    if (m == 0)
        return n + 1;
    else 
        if (n == 0 && m > 0)
            return AkkermanFun (m - 1, 1);
        else
            return (AkkermanFun (m - 1, AkkermanFun (m, n - 1)));
}