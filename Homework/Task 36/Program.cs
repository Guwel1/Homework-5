// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-100, 100);
}


void SumNumbers(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
int m = i % 2;
if (m == 1)
sum = sum + array[i];
}
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sum}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
SumNumbers(array);
