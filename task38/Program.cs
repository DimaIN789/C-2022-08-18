// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.WriteLine("Укажате количество элементов массивов");
int num1 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num1];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 100);
}
Console.WriteLine(string.Join(", ", array));

int Max = array[1];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= Max)
    {
        Max = array[i];
    }
}

int Min = array[1];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] <= Min)
    {
        Min = array[i];
    }
}

// Console.WriteLine(Min);
// Console.WriteLine(Max);
Console.WriteLine($"Pазницa между максимальным и минимальным элементов массива = {Max - Min}");