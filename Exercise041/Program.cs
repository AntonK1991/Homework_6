// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

int[] FillArrayByUser(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите значение элемента:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void NumbersCount(int[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > 0) count++;
    }
    Console.WriteLine("Количество элементов больше 0 - " + count);
}

Console.Write("Введите количество элементов массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] list = new int[M];

NumbersCount(FillArrayByUser(list));