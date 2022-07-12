//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void PrintDay(int num)
{
    if(num > 0 && num < 8)
    {
        if (num == 6 || num == 7) Console.WriteLine("Выходной");
        else Console.WriteLine("Увы, это рабочий день");
    }
    else Console.WriteLine("Такого дня несуществует, идите в школу!");
}
Console.WriteLine("Введите число дня недели: ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());

PrintDay(numberOfDay);
