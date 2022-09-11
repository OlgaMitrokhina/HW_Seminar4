// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



Console.WriteLine ("Введите число A: ");
int n1;
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число B: ");
int n2;
n2 = Convert.ToInt32(Console.ReadLine());
int degree;
degree = n1;

if (n2 > 0)
{
   for (int i = 1; i < n2; i++)
   {
    degree = degree * n1;
   }
}
else
{
   Console.WriteLine("Вы ввели неправильное число, степень числа должна положительной");
   return;
}

Console.WriteLine ($"Число A в степени B = {degree}");
