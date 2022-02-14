/* Написать программу масштабирования фигуры
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"*/

Console.Clear();

Console.Write("Задайте коэффициент масштабирования фигуры: ");
double k = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите список координат вершин фигуры через запятую: ");

var input = Console.ReadLine().Split(',');
var myList = new List<int>(input.Select(int.Parse));

Console.WriteLine("Начальная координата \tМасштабированная координата ");
foreach (var item in myList)
{
    Console.WriteLine($"\t{item} \t\t\t\t{item * k:0.0}");
}
Console.WriteLine();
