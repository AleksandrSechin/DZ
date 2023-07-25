//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
//  чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Укажите количество вводимых чисел: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

void Fill(int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Count(int[] array)
{
    int i = 0;
    int count = 0;
    while (i < array.Length)
    {
        if (array[i] > 0)
        count = count + 1;
        i = i + 1;
    }
    return count;
}

Fill(number);
Console.Write($"Чисел больше нуля: {Count(array)}");