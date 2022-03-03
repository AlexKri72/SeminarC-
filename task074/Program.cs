// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

Console.Clear();

Console.Write("Задайте длину слов: ");
int l = int.Parse(Console.ReadLine());

string massive = "аисв";

void Show(string array, char[] n, int length = 0)
{
    if (length == n.Length)
    {
        Console.WriteLine(new String(n)); return;
    }
    for (int i = 0; i < array.Length; i++)
    {
        n[length] = array[i];
        Show(array, n, length + 1);
    }
}
Show(massive, new char[l]);
Console.WriteLine();
