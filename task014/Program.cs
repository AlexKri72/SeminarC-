// Найти третью цифру числа или сообщить, что её нет

Console.Clear();

string text = Convert.ToString(new Random().Next(1, 201));
Console.WriteLine($"Введено случайное число: {text}");
if (text.Length >= 3)   Console.WriteLine($"Третья цифра числа: {text[2]}");
else                    Console.WriteLine("Число слишком короткое, нет третьей цифры!");

Console.WriteLine();
