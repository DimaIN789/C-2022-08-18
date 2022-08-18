// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Укажате количество элементов массивов");
int num1 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num1];
Random rand = new Random();

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(99, 1000);
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(count);
