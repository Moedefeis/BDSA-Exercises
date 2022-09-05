using ConsoleApp;

var input = Console.ReadLine();
int year = int.Parse(input);
var leapYear = new LeapYear();
var isLeapYear = leapYear.IsLeapYear(year);

if (isLeapYear) 
{
    Console.WriteLine("yay");
}
else Console.WriteLine("nay");
