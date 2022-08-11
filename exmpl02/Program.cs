// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

//Задаем массив
//Заполняем массив случайными числами
//Определяем элементы на нечетных позициях
//Суммируем
//Выводим в консоль

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
        array[index] = new Random().Next();
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

int GetSumm(int[] array) // Метод определения не четных элементов
{
    int summ = 0;

    for (int i = 1; i < len; i += 2)
    {
        summ += array[i];
    }
    return summ;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма на нечетных позициях в массиве {GetSumm(array)}");