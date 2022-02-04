// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.Clear();


bool[] x = { true, false };
bool[] y = { true, false };
bool z,z1;
Console.WriteLine("          X              Y            ¬(X v Y)         ¬X ^ ¬Y            ¬(X v Y) = ¬X ^ ¬Y      ");
Console.WriteLine("________________________________________________________________________________________________");
int index = 0;
while (index <= 1)
{
    int count = 0;
    while (count <= 1)
    {
        z = !(x[index] || y[count]);
        Console.Write($"     \t{x[index]}       \t{y[count]}      \t{z}");
        z1 = !x[index] && !y[count];
        Console.Write($"         \t{z1}");
        if (z==z1) Console.WriteLine($"                \t{z==z1}");
        else Console.WriteLine($"         \t{z==z1}");
        count++;
    }
    index++;
}
Console.WriteLine();

