// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {num} равна {GetSumDigits(num)} ");

int GetSumDigits(int number)
{
    int sum = 0;
    while (number>0)
    {
        int digit = number % 10;
        sum = sum + digit;
        number = number / 10;   
    }
        return sum;
}