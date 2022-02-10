// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.Clear();


bool[] x = { true, false };
bool[] y = { true, false };
bool z, z1;
Console.WriteLine("          X              Y            ¬(X v Y)         ¬X ^ ¬Y            ¬(X v Y) = ¬X ^ ¬Y      ");
Console.WriteLine("________________________________________________________________________________________________");
int index = 0;
while (index <= 1)
{
    int count = 0;
    while (count <= 1)
    {
        z = !(x[index] || y[count]); // левая часть равенства
        Console.Write($"\t{x[index]} \t\t{y[count]} \t\t{z}");
        z1 = !x[index] && !y[count];  // правая часть равенства
        Console.Write($"\t\t{z1}");
        if (z == z1) Console.WriteLine($"\t\t\t{z == z1}");
        else Console.WriteLine($"\t\t\t{z == z1}");
        count++;
    }
    index++;
}
Console.WriteLine();

