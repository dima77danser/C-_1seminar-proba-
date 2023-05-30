// напишите прог кот принимает на вход координаты 2 точек
// и находит расстояние между ними в 2д пространстве

Console.WriteLine("Введите число от 1 до 4");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число от 1 до 4");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число от 1 до 4");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число от 1 до 4");
int y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
Console.WriteLine(d);