﻿// Рекурсия:  Показать натуральные числа от 1 до N, N задано

Console.Clear();

Console.Write("Задайте число: ");
int n = int.Parse(Console.ReadLine());

int NaturalNumber(int num)
{
    int i =1;
    if (num == 2) return i;
    else 
    {
        num--;
        Console.Write($"{NaturalNumber(num):d2} ");
    }
    return num;
}
NaturalNumber(n+2);