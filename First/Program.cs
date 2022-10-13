void DecreaseIntegerNumbers (int N)
{
    if (N == 1) Console.Write("1");
    else {
        Console.Write($"{N}, ");
        DecreaseIntegerNumbers(N-1);
    }
}

Console.Clear();
Console.WriteLine("Задача 64: Задайте значение N. Напишите программу,"); 
Console.WriteLine("которая выведет все натуральные числа в промежутке от N до 1.");
Console.WriteLine("Выполнить с помощью рекурсии.");
Console.WriteLine();
Console.Write("Введите целое число больше 1: ");
int N = Convert.ToInt32(Console.ReadLine());
while (N <= 1)
{
    Console.Write("Число БОЛЬШЕ единицы: ");
    N = Convert.ToInt32(Console.ReadLine());
}

DecreaseIntegerNumbers(N);