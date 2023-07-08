

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату по оси оХ для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси оY для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси оY для первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оХ для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси оY для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси оY для второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Round(Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2 )), 0.5),2);

Console.WriteLine($"Расстояние: {d}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int start = 1;
Console.Write("Введите число: ");
int end = Convert.ToInt32(Console.ReadLine()); // N

while (start <= end)
{
    Console.Write(Math.Pow(start, 3) + " "); // start во степень
    start++; // start = start + 1 - инкремент
}


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter a Number To Check Palindrome : ");
int number = int.Parse(Console.ReadLine());
int remineder, sum = 0;int temp = number;
while (number > 0)
{
                //Get the remainder by dividing the number with 10  
    remineder = number % 10;
                //multiply the sum with 10 and then add the remainder
    sum = (sum * 10) + remineder;
                //Get the quotient by dividing the number with 10 
    number = number / 10; 
}
if (temp == sum)
{
    Console.WriteLine($"Number {temp} is Palindrome.");
}
else
{
    Console.WriteLine($"Number {temp} is not Palindrome");
}
Console.ReadKey();
