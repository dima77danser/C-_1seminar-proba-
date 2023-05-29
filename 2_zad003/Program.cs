// напишите программу,кот будет принимать
//  на вход 2 числа и выводить, является ли
//  2 число кратным 1
//  Если 2 число не кратно 1 , то программа выводит 
//  остаток от деления

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 ==0)
{
    Console.WriteLine("кратно");
}
else
{

    Console.WriteLine("ostatok ot deleniq"+num1 % num2);
    // Канкатинацией
    // Console.WriteLine("ostatok ot deleniq");
    // Console.WriteLine(num1 % num2);
    // интерполяция
    // Console.WriteLine($"ostatok ot deleniq {num1 % num2}");
   
}



