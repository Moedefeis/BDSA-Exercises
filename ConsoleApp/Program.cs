using ConsoleApp;

var input = Console.ReadLine();
int year = int.Parse(input);
var leapYear = new LeapYear();
var isLeapYear = leapYear.IsLeapYear(year);

Console.WriteLine(isLeapYear ? "yay" : "nay");
