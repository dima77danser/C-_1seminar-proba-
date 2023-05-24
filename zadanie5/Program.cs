// Напишите программу, которая принимает на вход трехзначное число
// и на вычоде показывает последнюю цифру этого числа

Console.WriteLine("ВВедите число:");
int num = Convert.ToInt32(Console.ReadLine());

if ((num>99)&&(num<1000))
{
    int num2 = num%10;
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("Введите трехзначное число" );
}

