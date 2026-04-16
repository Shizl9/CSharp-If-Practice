// See https://aka.ms/new-console-template for more information
Console.WriteLine("please Enter numper:");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{ Console.WriteLine("positive"); }
else if (num < 0)
{ Console.WriteLine("nigative"); }
else if (num==0)
    { Console.WriteLine("zero"); }
else { Console.WriteLine("Invalid Input!");}