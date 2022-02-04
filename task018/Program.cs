// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.Clear();


bool[] x = { true, false };
bool[] y = { true, false };
bool z;
Console.WriteLine("          X              Y            ¬(X v Y)         ¬X ^ ¬Y");
Console.WriteLine("________________________________________________________________");
int index = 0;
while (index <= 1)
{
    int count = 0;
    while (count <= 1)
    {
        z = !(x[index] || y[count]);
        Console.Write($"     \t{x[index]}       \t{y[count]}      \t{z}");
        z = !x[index] && !y[count];
        Console.WriteLine($"         \t{z}");
        count++;
    }
    index++;
}
Console.WriteLine();

