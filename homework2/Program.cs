// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12


System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
int c = 0;
int i = 0;
c = a;
    for (i = 0; c > 0; i++)
    {
        c = c/10;
    }
c = a;
    for (int j = 0; j <= i; j++)
    {   
        b = b + (c % 10);
        c = c / 10;
    }
System.Console.WriteLine(b);