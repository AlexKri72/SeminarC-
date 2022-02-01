// Даны два числа. Показать большее и меньшее число
Console.Clear();
Console.Write("Введите первое число: ");
int n1 = int.Parse (Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = int.Parse (Console.ReadLine());
int max,min;
if (n1>n2)
{
    max = n1;
    min = n2;
}
else
{
    max = n2;
    min = n1;
}
Console.WriteLine("Max = " + max + ", Min = " + min);