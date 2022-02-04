// Программа проверяет пятизначное число на палиндромность

Console.Clear();

Console.Write("Введите любое пятизначное число: ");
string a = Convert.ToString(Console.ReadLine());
if (a.Length==5)
{
if (a[0]==a[4] && a[1]==a[3])   Console.WriteLine("Заданное число является ПАЛИНДРОМОМ!");
else Console.WriteLine("Заданное число не является палиндромом!");
}
else Console.WriteLine("Ошибка, было задано не пятизначное число!");

Console.WriteLine();
