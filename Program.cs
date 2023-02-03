// // Задача 19

// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// // 14212 -> нет

// // 12821 -> да

System.Console.WriteLine("Задача №19 ");
System.Console.Write("Введите 5-ти значное число: ");

int number = Convert.ToInt32(Console.ReadLine());

    int numberA = number / 10000;
    int numberB = (number / 1000) % 10;
    int numberD = (number % 100) / 10;
    int numberE = number % 10;

if ((numberA==numberE) && (numberB==numberD))

{
     System.Console.WriteLine("палиндром");
}  

else 
{
    System.Console.WriteLine("не палиндром");
}  

// // Задача 21

// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// // A (3,6,8); B (2,1,-7), -> 15.84

// // A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Задача №21 ");
System.Console.WriteLine("Введите по три координаты двух точек: ");

System.Console.WriteLine("Точка A: ");

double numberX1 = Convert.ToInt32(Console.ReadLine());
double numberY1 = Convert.ToInt32(Console.ReadLine());
double numberZ1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Точка B: ");

double numberX2 = Convert.ToInt32(Console.ReadLine());
double numberY2 = Convert.ToInt32(Console.ReadLine());
double numberZ2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Pow((numberX1-numberX2),2) + Math.Pow((numberY1-numberY2),2) + Math.Pow((numberZ1-numberZ2),2);

System.Console.WriteLine(Math.Sqrt(result));


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 275
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Задача №23 ");
System.Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

int i=1;

while (i<=num)
{
    System.Console.Write(Math.Pow(i, 3) + " ");
    i=i+1;
}