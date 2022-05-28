// Напишите цикл, который принимает на вход два числа (A и B) и возводит число А в натуральную степень B. 
//Задачу решить без использования Math Pow.
Console.WriteLine("Введите число A: ");
int value = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень B для числа A: ");
int step = int.Parse(Console.ReadLine());
int valuestep = 1;
for (int i = 0; i < step; i++)
{
   valuestep *= value;
}
Console.WriteLine($"{value} ^ {step} = {valuestep}");
 
