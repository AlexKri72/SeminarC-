// Показать четные числа от 1 до N

Console.Clear();

int n = new Random().Next(1,101);
int index = 2;
Console.WriteLine("Задано максимальное число: " + n);
Console.Write("Четные числа : ");
while (index <= n )
{
    if ( index % 2 == 0 )
        {
            Console.Write( index + " ");
        }
    index+=2;
}
Console.WriteLine();
Console.WriteLine();

