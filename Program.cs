// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(11);
// }
// Console.WriteLine($" Array: [ {string.Join("; ", array)} ]");
// int temp = 0;
// int size = array.Length;
// for (int j = 0; j < size/2; j++)
// {
//     temp = array[j];
//     array [j] = array[size - j - 1];
//     array[size - j - 1] = temp;
// }
// Console.WriteLine($" Array: [ {string.Join("; ", array)} ]");

// Варинт с созданием нового массива

// int size = 5;
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(11);
// }
// Console.WriteLine($" Array: [ {string.Join("; ", array)} ]");

// int [] resultArray = new int[size];
// int lastIndex = size - 1;
// for (int i = 0; i < size; i++)
// {
//     resultArray [i] = array[lastIndex - i];
// }
// Console.WriteLine($" Array: [ {string.Join("; ", resultArray)} ]");

// С помощью методов:

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] reversArray=CopyArray(array);
// Console.WriteLine(String.Join(" ", reversArray));

// ReversArray(array);
// Console.WriteLine(String.Join(" ", array));


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// void ReversArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int temp = inArray[i];
//         inArray[i] = inArray[inArray.Length - i - 1];
//         inArray[inArray.Length - i - 1] = temp;
//     }
// }

// int[] CopyArray(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];

//     }
//     return result;
// }


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Ведите первое число");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите второе число");
// int secondNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите третье число");
// int thirdNum = Convert.ToInt32(Console.ReadLine());
// if( firstNum < secondNum + thirdNum && secondNum < firstNum + thirdNum && thirdNum < firstNum + secondNum ) Console.WriteLine("Треугольник со сторонами указаного размера существует");
// else Console.WriteLine("Треугольник со сторонами указаного размера не существует");

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Ведите желаемое количество чисел фибоначи");
// int number = Convert.ToInt32(Console.ReadLine());
// int firstNum = 0;
// int secondNum = 1;
// Console.Write(" Последовательность фибоначи искомой длинны: 0 1 ");
// for (int i = 3; i <= number; i++)
// {
//     int fibonachi = firstNum + secondNum;
//     firstNum = secondNum;
//     secondNum = fibonachi;
//     Console.Write(fibonachi + " ");
// }

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] array = new int[5];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(11);
// }
// Console.WriteLine($" Array: [ {string.Join("; ", array)} ]");
// Console.WriteLine($" CopiedArray: [ {string.Join("; ", CopyArray(array))} ]");

// int[] CopyArray(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[i];

//     }
//     return result;
// }

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Ведите количество чисел");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 1; i <= M; i++)
{
    Console.WriteLine("Ведите число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count++;
}
Console.WriteLine("Количество чисел больше нуля равно " + count);

// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Ведите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ведите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ведите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ведите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2) Console.WriteLine("Задача не имеет решения с помощью использующегося метода");
else
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k2* x + b2;
    Console.WriteLine("Точкой пересечения прямых являются координаты [" + x + "; " + y + "]");
}

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


Console.WriteLine("Ведите желаемое десятичное число");
int number = Convert.ToInt32(Console.ReadLine());
while ( number != 0)
{
    Console.Write(number%2);
    number = number / 2;
}