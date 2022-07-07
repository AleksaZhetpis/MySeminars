/* Задача № 1: Пользователь вводит два числа. Надо определить, является ли первое число квадратом второго числа.

int num1, num2, quad;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if(quad == num1)
{
  Console.WriteLine("First number is quad of second number");
}
else
{
  Console.WriteLine("First number is not a quad of second number");
}
*/


// Привет


/*Задача № 2: Напишите программу, которая будет выдавать название дня недели по заданному номеру.

int day;

Console.Write("Введите число дня недели от 1 до 7: ");
day = Convert.ToInt32(Console.ReadLine());

if(day == 1)
{
  Console.WriteLine("Понедельник");
}
if(day == 2)
{
  Console.WriteLine("Вторник");
}
if(day == 3)
{
  Console.WriteLine("Среда");
}
if(day == 4)
{
  Console.WriteLine("Четверг");
}
if(day == 5)
{
  Console.WriteLine("Пятница");
}
if(day == 6)
{
  Console.WriteLine("Суббота");
}
if(day == 7)
{
  Console.WriteLine("Воскресенье");
}
if(day > 7 || day < 1)
{
  Console.WriteLine("Какая цифра?");
}
*/




/*Задача № 3: Напишите программу, которая на вход принимает число и выдаёт его квадрат.

int num, quad;

Console.Write("Input a number: ");
num = Convert.ToInt32(Console.ReadLine());

quad = num * num;

Console.Write("quad number is: " + quad);
*/

/*Задача № 4: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N

int n, current;

Console.Write("Input a number: ");
n = Convert.ToInt32(Console.ReadLine());

current = n * (-1);

while (current <= n)
{
   Console.Write(current + " ");
   current++; // current = current +1
}
*/
















