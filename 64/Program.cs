//Задача 64: Задайте значение N. Напишите программу,
//которая выведет все натуральные числа в промежутке 
//от N до 1. Выполнить с помощью рекурсии.

//M = 5; N = 3 -> "5, 4, 3"
//M = 8; N = 4. -> "8, 7, 6, 5, 4"

Console.Clear();
Console.WriteLine("Введите натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());

void Number (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    Number (number - 1);
}

Number(number);