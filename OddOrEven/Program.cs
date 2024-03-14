// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number:");
int Usernum = Convert.ToInt32(Console.ReadLine());
int result = Usernum % 2;
Console.WriteLine(result);
if (result != 0)
{
    Console.WriteLine("User number is odd.");
}else
{
    Console.WriteLine("User number is even.");
}
