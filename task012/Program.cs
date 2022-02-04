// Удалить вторую цифру трёхзначного числа

Console.Clear();

string text = Convert.ToString(new Random().Next(100,1000));
Console.WriteLine($"Введено случайное трехзначное число : {text}"); 
text = text.Remove(1,1);
Console.WriteLine($"Без второй цифры осталось {text} ");

Console.WriteLine();