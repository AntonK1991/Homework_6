// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

void Input(out double b1, out double k1, out double b2, out double k2)
{
    Console.Write("Введите значение b1:");
    b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение k1:");
    k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение b2:");
    b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение k2:");
    k2 = Convert.ToDouble(Console.ReadLine());
}

double FindDiffB(double b1, double b2)
{
    double result = 0;
    if (b1 == b2) Console.WriteLine("Прямые совпдают!");
    else
        result = b2 - b1;
    return result;
}

double FindDiffK(double k1, double k2)
{
    double result = 0;
    if (k1 == k2) Console.WriteLine("Прямые параллельны!");
    else
        result = k1 - k2;
    return result;
}

double FindX(double b, double k)
{
    double x = b / k;
    return x;
}

double FindY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    System.Console.WriteLine($"({x};{y})");
    return y;
}

double b1, k1, b2, k2;
Input(out b1, out k1, out b2, out k2);
FindY(k1, b1, FindX(FindDiffB(b1, b2), FindDiffK(k1, k2)));
