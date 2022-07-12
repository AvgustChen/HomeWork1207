//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Number(int number)
{
    int num = number / 10 % 10;
    return num;
}
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Number(number);

Console.WriteLine(result);

