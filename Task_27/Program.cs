// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе. Задачу решить без использования строк (string). (Решение задачи для положительных чисел)
Console.WriteLine("Введите положительное число: ");
int value = int.Parse(Console.ReadLine());
int sumresult = 0;
Console.Write($"В числе {value}");
while (value > 0) //решение для положительных чисел
{
    sumresult += value % 10;
    value /= 10;
}
Console.WriteLine($" cумма цифр = {sumresult}");

