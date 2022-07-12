/*// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
void MaxMin(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.WriteLine("Максимальное из этих чисел: " + num1);
        Console.WriteLine("Минимальное из этих чисел: " + num2);
    }
    else
    {
        Console.WriteLine("Максимальное из этих чисел: " + num2);
        Console.WriteLine("Минимальное из этих чисел: " + num1);
    }
}

Console.WriteLine("Приветствую, данная программа определит какое из ваших чисел больше!");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

MaxMin(num1, num2);*/



/*
int Max(int num1, int num2, int num3)
{
    int max;
    if (num1 > num2)
    {
        max = num1;
    }
    else
    {
        max = num2;
    }
    if (num3 > max)
    {
        max = num3;
    }
    return max;
}
Console.WriteLine("Приветствую, данная программа определит какое из ваших чисел больше!");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = Max (num1, num2, num3);
Console.WriteLine($"Максимальное число {max}");*/



/*
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
bool Check(int num)
{
    if(num % 2 == 0) return true;
    else return false;
}
Console.WriteLine("Приветствую, данная программа определит является ли ваше число четным!");
Console.Write("Введите Ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool check = Check(num);
if(check) Console.Write("Число четное!");
else Console.Write("Число нечетное!");*/



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
void Numbers(int num)
{
    if (num > 0)
    {
        int current = 1;
        while (current <= num)
        {
            if (current % 2 == 0)
                Console.Write(current + " ");
            current++;
        }
    }
else Console.Write("Вы пытаетесь нас обмунуть и ввели отрицательное число!!!");
    }
    Console.WriteLine("Приветствую, данная программа все четные числа от 1 до Вашего числа");
    Console.Write("Введите Ваше число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    Console.Write("Итого: ");
    Numbers(num);
