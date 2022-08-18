// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.WriteLine("Укажате количество элементов массивов");
int num1 = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num1];

Random rand = new Random();

for (int i = 0; i < array.Length; ++i)
{
    array[i] = rand.Next(-9, 10);
}
Console.WriteLine(string.Join(", ", array));

for (int i = 0; i < array.Length; ++i)
{
    array[i] = -array[i];
}

Console.WriteLine(string.Join(", ", array));
