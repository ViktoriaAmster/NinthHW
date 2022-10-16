int Akkerman (int m, int n)
{
    if (m == 0) return n+1;
    else if (n == 0) return Akkerman(m-1,1);
    else return Akkerman(m-1,Akkerman(m,n-1));
}

Console.Clear();
Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.");
Console.WriteLine("Даны два неотрицательных числа m и n.");
Console.WriteLine();
Console.Write("Enter greater than or equal to zero coefficient m: ");
int coefficientM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter greater than or equal to zero coefficient n: ");
int coefficientN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M={coefficientM}, N={coefficientN} ---> Akkerman function={Akkerman(coefficientM,coefficientN)}");


