//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Укажате количество элементов массивов");
int num1 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num1];
Random rand = new Random();

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 100);
}
Console.WriteLine(string.Join(", ", array));


for (int i = 1; i < array.Length; i = i + 2)
{
    sum += array[i];
    // sum = sum + array[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");

