//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("ВВедите пятизначное число :");
string number =Console.ReadLine()!;
Console.Write(number);
bool isPalyndrome = Polindrom(number);
string txt = isPalyndrome == true? "Является полиндромом" : " Не полиндром";
Console.WriteLine(txt);

bool Polindrom(string number)
{
    for  (int i = 0; i < number.Length / 2; i++)
{
    if (number [i] != number[number.Length -i -1])
    return false;
    }

    return true;
}




//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Напишите координаты двух точек"x1 y1 z1 x2 y2 z2:");
var line = Console.ReadLine().Split();
for (int i = 0; i < 3; i++)
{ d = Convert.ToDouble(line[i + 3])
- Convert.ToDouble(line[i]);
distance += d * d; }
Console.WriteLine("r = " + Math.Sqrt(distance));




// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
