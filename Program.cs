
//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("ВВедите пятизначное число");
string number =Console.ReadLine()!;
Console.Write(number);
bool isPalyndrome = Polindrom(number);
string txt = isPalyndrome == true? "-> YES" : " -> NO";
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