// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter three numbers:");

Console.Write("Number 1: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Number 2: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Number 3: ");
double num3 = Convert.ToDouble(Console.ReadLine());

if (num1 + num2 >num3&&num2+num3 > num1 && num1 + num3 > num2)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("No");
}
