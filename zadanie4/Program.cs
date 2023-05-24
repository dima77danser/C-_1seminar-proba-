// НАписать программу, которая на вход принимает одно число(N), 
// a na vyxode pokazyvaet все целые числа в промежутке от -N do N

Console.WriteLine("ВВедите число:");
int num = Convert.ToInt32(Console.ReadLine());

int negNumber = -1*num;

while (negNumber<=num)
{
    Console.Write(negNumber);
    negNumber = negNumber +1;
}
