Console.Clear();
int number = int.Parse(Console.ReadLine());
f(number);

void f(int countTests)
{
    int fibonacci1 = 0;
    int fibonacci2 = 1;
    Console.Write($"f({0}) = {0}; ");
    for (int i = 1; i < countTests; i++)
    {
        Console.Write($"f({i}) = {fibonacci2}; ");
        int temporary = fibonacci2;
        fibonacci2 += fibonacci1;
        fibonacci1 = temporary;
    }
}
// **Задача 1:**Пользователь вводит с
//  клавиатуры M чисел. Посчитайте, сколько чисел 
//  больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

// **Задача 2:**Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)