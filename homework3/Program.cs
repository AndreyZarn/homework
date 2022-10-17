// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] arr = new int[8];
//arr[8] = new Random().Next(1,100);
void Ind (int[] arr)
{
    for (int i = 0; i<arr.Length; i++)
    {
        Console.Write(arr[i]);
        Console.Write(",");
    }

}
void Rand (int[] arr)
{
   for (int i = 0; i<arr.Length; i++)
   {
   arr[i] = new Random().Next(1,100);
   }
}
Rand(arr);
Ind(arr);
Console.WriteLine();