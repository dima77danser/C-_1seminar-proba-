//  написать программу, 
// которая на вход принимает 2 числа и проверяет,является 
// ли первое число квадратом второго


Console.WriteLine("ВВедите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num ==num2*num2)
{
    Console.WriteLine("da");
}
else
{
    Console.WriteLine("net");
}


