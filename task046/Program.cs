/* Написать программу масштабирования фигуры
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"*/

Console.Clear();

Console.Write("Задайте коэффициент масштабирования фигуры: ");
double k = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите список координат вершин фигуры в формате (0,0) (4,0) (4,4) (0,4): ");

string[] input = Console.ReadLine().Replace("(","").Replace(")","").Replace(" ",",").Split(',');

double[] coordination = new double[input.Length]; // переделываем строковый массив в вещественный
for (int i = 0; i < input.Length; i++)
{
    coordination[i] = Convert.ToDouble(input[i]);
}

Console.WriteLine("Начальная координата \tМасштабированная координата "); // распечатываем результат
for (int i = 0; i < coordination.Length; i++)
{
    Console.WriteLine($"\t{coordination[i]:0.} \t\t\t\t{coordination[i] * k:0.0}");
}
Console.WriteLine();
