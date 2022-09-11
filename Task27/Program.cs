// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine ("Введите число: ");
int n;
n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (n > 0 || n < 0)
{
  sum = sum + n%10;
  n = n/10;
}
sum = Math.Abs(sum);
Console.WriteLine ($"Сумма равна {sum}");
