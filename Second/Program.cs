int SumIntegerNumbersFromTo (int M, int N)
{
    int sum = 0;
    if (M <= N) sum += M + SumIntegerNumbersFromTo(M+1, N);
    return sum;
}



Console.Clear();
Console.WriteLine("Задача 66: Задайте значения M и N. ");
Console.WriteLine("Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");

Console.Write("Задайте первое число диапазона: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте последнее число диапазона: ");
int lastNumber = Convert.ToInt32(Console.ReadLine());

int sumNumbersFromTo = SumIntegerNumbersFromTo(firstNumber,lastNumber);
Console.WriteLine($"Сумма чисел в диапазоне от {firstNumber} до {lastNumber} включительно = {sumNumbersFromTo}");

