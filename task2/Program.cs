// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
System.Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numberA];
Random rand = new Random();
int numberB = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    System.Console.Write(array[i] + " ");
    if (i % 2 == 1)
    {
        numberB = numberB + array[i];
    }

}
System.Console.Write($"  Сумма ->" + " " + numberB);
