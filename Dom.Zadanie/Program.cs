Console.Clear();

// Task 10
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Введите трехзначное число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
while (number1 < 100 || number1 > 999)
{
    Console.WriteLine("Вы ошиблись!\nВведите трехзначное число: ");
    number1 = Convert.ToInt32(Console.ReadLine());
}
int number2 = 0;
number2 = number1 / 10;
Console.WriteLine($"Вторая цифра {number1} будет {number2 % 10}");
*/

// Task 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.WriteLine("Введите число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
int number3 = number1;
int number2 = 0;
while (number1 > 999)
{
    if (number1 > 999)
        {
            number1 = number1 / 10; 
        }
}
if (number1 < 100) Console.WriteLine($"В числе {number3} нет третьей цифры! ");
else
    {
    number2 = number1;
    Console.WriteLine($"Третья цифра {number3} будет {number2 % 10}");
    }

*/

// Task 15
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.WriteLine("Введите номер дня недели: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
while (number1 < 1 || number1 > 7)
{
    Console.WriteLine("Вы ошиблись!\nВведите от 1 до 7: ");
    number1 = Convert.ToInt32(Console.ReadLine());
}
if (number1 == 6 || number1 == 7) Console.WriteLine("Это выходной!");
else
{
    Console.WriteLine("Это будний день");
}
*/

// Task Second maximum
// Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется определить значение второго 
// по величине элемента в этой последовательности, то есть элемента, который будет наибольшим, если из 
// последовательности удалить наибольший элемент.


Console.WriteLine("Вводите числа: ");
int n = Convert.ToInt32(Console.ReadLine());
int max1 = 0;
int max2 = 0;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max1 ) 
    {
        max2 = max1;
        max1 = n;
    }
     else if(n > max2 && n != max1) max2 = n;
}
Console.WriteLine($"Второй максимум {max2}");
