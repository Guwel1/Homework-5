// Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 1000);
}


void CountNumbers(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
int m = array[i] % 2;
if (m == 0)
count ++;
}
Console.WriteLine($"Количество чётных чисел в массиве: {count}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
CountNumbers(array);
