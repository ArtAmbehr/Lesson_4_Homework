// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int res = numberA;
Console.WriteLine($"Число {numberA}, возведенное в степень {numberB}, равно {GetPower(res)} ");

int GetPower(int result)
{
int count = 1;
int res = numberA;

    while (count < numberB)
    {
        result = result * numberA;
        count++;
    }
    return result;
}
