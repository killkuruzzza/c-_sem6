//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

Console.Clear();
Console.Write("Введите стороны треугольника через пробел: ");

string[] st = Console.ReadLine().Split(' ');
int a = int.Parse(st[0]);
int b = int.Parse(st[1]);
int c = int.Parse(st[2]);

if (IsTriangle(a, b, c)){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}

bool IsTriangle(int a, int b, int c){
    return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
}


    // **Задача 42:**Напишите программу,
    //  которая будет преобразовывать десятичное число в двоичное.

    // 45 -> 101101

    // 3 -> 11

    // 2 -> 10