// See https://aka.ms/new-console-template for more information
//Task One: Write a program that prints the next 20 leap years
/*
 A leap year usually occurs every 4 years. The last/current leap year was in 2020.
 An array (variable for storing related data), in this case, an array of integers, leapYears stores 
 the next 20 leap years.
*/

int[] leapYears = new int[20];

int currentLeapYear = 2020;
int leapYearCount = 4;

foreach (int leapYear in leapYears)
{
    currentLeapYear += leapYearCount;
    Console.WriteLine(currentLeapYear);
}







