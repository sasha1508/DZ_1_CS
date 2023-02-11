// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

internal class Program
{
    private static void Main()
    {
        Console.Clear();
        Console.Write("Введи номер задачи (2, 4, 6, 8): ");
        int ZadachaNumber = Convert.ToInt32(Console.ReadLine());
        if (ZadachaNumber == 2)       {Zadacha2();}
        else if (ZadachaNumber == 4)  {Zadacha4();}
        else if (ZadachaNumber == 6)  {Zadacha6();}    
        else if (ZadachaNumber == 8)  {Zadacha8();}  
        else {Console.WriteLine("Введён номер, не соответствующий задаче.");;}    
    }

    private static void Zadacha2()
    {
        Console.WriteLine("Задача 2. Сравнение двух чисел.");
        Console.Write("Введи число 'a': ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введи число 'b': ");
        int b = Convert.ToInt32(Console.ReadLine());
        if(a>b)         {Console.WriteLine("Число 'a'(" + a + ") блоьшее, число 'b'(" + b + ") меньшее.");}
        else if (a<b)   {Console.WriteLine("Число 'b'(" + b + ") блоьшее, число 'a'(" + a + ") меньшее.");}
        else            {Console.WriteLine("Числf 'a'(" + b + ") и 'b'(" + a + ") равны.");}
    }
    private static void Zadacha4()
    {
        Console.WriteLine("Задача 4. Нахождение максимального числа из трёх чисел.");
        Console.Write("Введи число 'a': ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введи число 'b': ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введи число 'с': ");
        int c = Convert.ToInt32(Console.ReadLine());
        int max = a;
        if (b > max) {max = b;}
        if (c > max) {max = c;}
        Console.WriteLine("Максимальное число: " + max);
    }
    private static void Zadacha6()
    {
        Console.WriteLine("Задача 6. Проверка на чётность.");
        Console.Write("Введи число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int ostatok = a % 2;
        if (ostatok == 0) {Console.WriteLine("Число чётное.");}
        else {Console.WriteLine("Число нечётное.");}
    }
    private static void Zadacha8()
    {
        Console.WriteLine("Задача 8. Вывод чётных чисел от 1 до N.");
        Console.Write("Введи число N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i<=n ; i++)
        {
            if (i % 2 == 0) {Console.Write(i + " ");}
        }
    }
}