// НАписать прог кот на вход принимает число N
// и выдает таблицу квадратов чисел от 1 до N


Console.WriteLine("Введите число от 1 до 4");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;
while (num>=count)
{
    Console.WriteLine(Math.Pow(count,2));
    count++;
}

