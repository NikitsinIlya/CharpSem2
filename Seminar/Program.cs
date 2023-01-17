Console.Clear();
/*

int n = new Random().Next(10, 100); // [от 10 до 99]
Console.WriteLine($ "Случайное число: {n}");
int n1 = n / 10 
int n2 = n % 10;
if (n1 > n2)
    Console.WriteLine(n1);
else
    Console.WriteLine(n2);
    */
//Task11
/*
int n = new Random().Next(100, 1000); // [от 100 до 1000]
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 100 ;
int n3 = n % 10;
Console.WriteLine(n1 * 10 + n3);
*/

//Task12
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
/*
Console.Write("Введите 1-e число : ");
    int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-e число : ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int m = 0;
 if ( number1 % number2 == 0 ) 
 {
    Console.WriteLine("Кратно");
 }
 else 
 { 
    m = number1 % number2;
    Console.WriteLine($"{m}" );
 }
*/
// 2српособ
/*
Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n % m == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine($"no, {n % m}");
    */

//Task 14 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

/*
Console.Write("Введите 1-e число : ");
    int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 7 == 0 & number1 % 23 == 0)
    {
        Console.WriteLine("YES");
    }
else
 { 
    Console.WriteLine("No");
 }
*/

//Task 16 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


Console.Write("Введите 1-e число : ");
    int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-e число : ");
    int number2 = Convert.ToInt32(Console.ReadLine());
 if ( number1 * number1 == number2 || number2 * number2 == number1 )
 {
    Console.WriteLine("Yes");
 }
 else 
 { 
       Console.WriteLine("NO" );
 }
