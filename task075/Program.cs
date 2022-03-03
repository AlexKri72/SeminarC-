/* Есть два массива info и data.
Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей.
Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
Пример:
входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1  */

Console.Clear();
int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1 };
int [] result = new int [info.Length];
int count = 0;

for (int i = 0; i < result.Length; i++)
{
    for (int j = 0; j < info[i]; j++)
    {
     Console.Write(data[count + j]);    
    }
    count+= info[i];
    Console.Write("  ");
}
Console.WriteLine();

count = 0;

for (int i = 0; i < result.Length; i++)
{
    for (int j = 0; j < info[i]; j++)
    {
     //Console.Write(data[count + j]);   
     result[i] += data[count + j]*(int)Math.Pow(2, info[i] - j - 1);
    }
    count+= info[i];
    Console.Write(result[i]+ "  ");
}
Console.WriteLine();
