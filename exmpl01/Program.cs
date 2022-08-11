// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Задаем пустой массив из количества элементов, запрошенных у пользователя
// Заполняем массив (Random + отсеиваем не трехзачные)
// Отбираем четные 
// Выводим в консоль


int GetLength(string input) // метод преобразования в число
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}

int len = GetLength("Введите число элементов массива: ");
int[] array = new int[len];

void FillArray(int[] array) // Метод заполнения массива
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] col) // Метод печати массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int MainEx(int[] array) // Метод определения количества четных элементов
{
    int count = 0;

    for (int i = 0; i < len; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"В массиве {MainEx(array)} четных чисел");