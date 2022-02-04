// Дано число. Проверить кратно ли оно 7 и 23

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse (Console.ReadLine());
if (a % 7 ==0 && a % 23 ==0) Console.Write("Введенное число кратно 7 и 23 ");
else Console.Write("Введенное число не кратно 7 и 23");

