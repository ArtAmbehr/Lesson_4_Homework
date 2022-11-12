// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// (в примере показаны два разных массива, создаем именно для 8 элементов)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    } 
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
