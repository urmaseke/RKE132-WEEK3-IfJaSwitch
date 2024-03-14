int Weekday = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (Weekday == 0)
{
    Console.WriteLine("Its Sunday!");
}
else if (Weekday == 1)
{
    Console.WriteLine("Its Monday!");
}
else if (Weekday == 2)
{
    Console.WriteLine("Its Tuesday!");
}
else if (Weekday == 3)
{
    Console.WriteLine("Its Wednesday!");
}
else if (Weekday == 4)
{
    Console.WriteLine("Its Thursday!");
}
else if (Weekday == 5)
{
    Console.WriteLine("Its Friday!");
}
else 
{
    Console.WriteLine("Its Saturday!");
}

Console.WriteLine("Have a nice day!");