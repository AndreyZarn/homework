// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int sum = 1;
void Sum(int a, int b)
 {
    
    for (int i = 1; i<=b; i++)
    {
        sum = (sum*a);
    }

  Console.WriteLine(sum);
 }
System.Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Sum(a,b);