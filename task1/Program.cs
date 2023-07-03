// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numberA];
Random rand = new Random();
int numberB = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        numberB = numberB + 1;
    }
    Console.Write(array[i] + " ");
}

Console.Write("  Четных чисел ->" + " " + numberB);

