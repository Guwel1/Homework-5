// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void InputArray(double[] array)
{
    Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = 5 - rand.Next(11) + rand.NextDouble();
            }
}


void MaxMinNumbers(double[] array)
{
double diff = 0;
double max = 0;
double min = 0;
for (int i = 0; i < array.Length; i++)
{
while (max > array[i] && max == 0)
{
    max = array[i];
}
while (max < array[i])
{
    max = array[i];
}
while (min > array[i])
{
    min = array[i];
}
    diff = max - min;
}
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {diff}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
MaxMinNumbers(array);