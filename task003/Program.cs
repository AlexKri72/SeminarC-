// По заданному номеру дня недели вывести его название

Console.Clear();
string[] array = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "вокресенье" };

Console.Write("Введите номер дня недели: ");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Это " + array[i - 1] + "!");