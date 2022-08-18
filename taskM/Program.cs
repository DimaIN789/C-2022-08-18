//  ШАБЛОН МАССИВА


Console.WriteLine("Укажате количество элементов массивов");
int num1 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num1];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 100);
}
Console.WriteLine(string.Join(", ", array));

