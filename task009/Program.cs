﻿// Показать последнюю цифру трёхзначного числа
Console.Clear();

string text = Convert.ToString(new Random().Next(100,1000));
Console.WriteLine($"Введено случайное трехзначное число : {text}"); 
Console.WriteLine($"Последняя цифра равна {text[2]} ");

Console.WriteLine();
