// Найти расстояние между точками в пространстве 2D/3D

Console.Clear();

Console.Write("Задайте двумерное или трехмерное пространство, введя соответствующую цифру: ");
int space = int.Parse(Console.ReadLine());
if (space ==2 || space == 3)    //есть проверка, если вводится другое число, то выдаёт ошибку
{
        //блок ввода координат
        double[] point1 = new double[3]{0,0,0};    
        double[] point2 = new double[3]{0,0,0};
        Console.WriteLine("Задайте координаты первой точки");
        Console.Write("X : ");
        point1[0] = double.Parse(Console.ReadLine());
        Console.Write("Y : ");
        point1[1] = double.Parse(Console.ReadLine());
        if (space == 3)     //третья координата вводится только для 3 мерного пространства
        {
            Console.Write("Z : ");
            point1[2] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Задайте координаты второй точки");
        Console.Write("X : ");
        point2[0] = double.Parse(Console.ReadLine());
        Console.Write("Y : ");
        point2[1] = double.Parse(Console.ReadLine());
         if (space == 3)    //третья координата вводится только для 3 мерного пространства
        {
            Console.Write("Z : ");
            point2[2] = double.Parse(Console.ReadLine());
        }
        //формула вычисления расстояния для двух- и трехмерного пространства одинакова, 
        //т.к. если пространство двумерное, то третьим компонентом формулы выступают нули, 
        //которые не влияют на результат вычисления
        double distance =   Math.Sqrt ( Math.Pow ((point1[0]-point2[0]) , 2 ) + Math.Pow ( (point1[1]-point2[1]) , 2 ) + Math.Pow ( (point1[1]-point2[1]) , 2 )       );
        Console.WriteLine($"Расстояние между заданными точками равно : {distance: 0.00} единицы.");
}
else Console.WriteLine("Ошибка, задана неправильная мерность пространства!");

Console.WriteLine();
