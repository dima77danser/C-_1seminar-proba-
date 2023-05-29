// 1. Напишите программу,кот принимает 
// на вход число и проверяет, кратно лионо одновременно 
// 7 и 23

// в условии if delaem 
// if((num % 7 == 0) (num % 23 ==0))
// esli одновременно надо выполнение то между ними &&
//если одно из условий то ||

// 2. напишите программу кот принимает 
// на вход 2 числа и проверяет, является ли
// одно число квадратом другого


Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

if ((num1 == num2*num2) || (num2 == num1*num1 ))
{
    Console.WriteLine("da");
}
else
{
    Console.WriteLine("net");
}

