// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] array = new int [12];

int[] arrayResalt = new int[(array.Length + 1) / 2];

Random rand = new Random();


for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 10);
}
Console.WriteLine(string.Join(", ", array));


for (int i = 0; i < arrayResalt.Length; i++)
{
    arrayResalt[i] = array[i] * array[array.Length - 1 - i];
}

if (array.Length % 2 == 1)
{
    arrayResalt[array.Length - 1] = array[array.Length / 2];
}
Console.WriteLine(string.Join(", ", arrayResalt));



// Length/2 + Length%2

