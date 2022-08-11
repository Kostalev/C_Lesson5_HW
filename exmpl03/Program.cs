// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


// Задаем массив вещественных чисел
// Заполняем массив
// Находим значение минимального элемента
// Находим значение максимального элемента
// Находим разницу


int GetLength(string input) // метод преобразования в число
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}

int len = GetLength("Введите число элементов массива: ");
double[] array = new double[len];

void FillArray(double[] array) // Метод заполнения массива
{
    int length = array.Length;
    int index = 0;
    Random rand = new Random();

    while (index < length)
    {
        array[index] = rand.NextDouble();
        index++;
    }
}

double FindMin(double[] array) // Метод поиска минимального значения
{

    double min = array[0];

    for (int i = 1; i < len; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double FindMax(double[] array) // Метод поиска максимального значения
{

    double max = array[0];

    for (int i = 0; i < len; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

void PrintArray(double[] col) // Метод печати массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}


FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Минимальное число в массиве: {FindMin(array)}");
Console.WriteLine($"Максимальное число в массиве: {FindMax(array)}");
Console.WriteLine($"Разница между максимальным и минимальным значением: {FindMax(array) - FindMin(array)}");