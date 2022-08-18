// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, 3] -> да
// // Массивы к задачам 32 и 33 можно сделать рандомными. 
// В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".

Console.WriteLine("Укажате количество элементов массивов");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число которое необходимо найти в массиве");
int num2 = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num1];

Random rand = new Random();

for (int i = 0; i < array.Length; ++i)
{
    array[i] = rand.Next(-9, 10);
}
Console.WriteLine(string.Join(", ", array));

int findElement = Convert.ToInt32(Console.ReadLine());
bool flag = false; // если false то элемента в массиве нет,иначе - есть

for (int i = 0; i < array.Length; ++i)
{
    if (findElement == array[i])
    {
        flag = true;
    }
}
if (flag == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("нет");
}



// for (int i = 0; i < array.Length; ++i)
// {
//     array[i] = rand.Next(-9, 10);
//     if (num2 == array[i])
//     {
//         Console.WriteLine("Да");
//     }
//     else 
//     {
//         Console.WriteLine("Нет");
//     }
// }

