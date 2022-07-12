// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Check(int number) // Функция проверяет - число больше 99?
{
    if (number < 99) return -1;
    else return 0;

}

int Number(int number) // Функция ищет третье число
{
    while (number > 999)
    {
        if (number > 999) number = number / 10;
    }
    int result = number%10;
    return result;   
}




int number = new Random().Next(1, 100000);
int result1 = Check(number);
int result2 = Number(number);
Console.WriteLine($"Сгенерированое число: {number}");


if (result1 == -1) Console.WriteLine("Третьего числа нет!");
else Console.WriteLine(result2);