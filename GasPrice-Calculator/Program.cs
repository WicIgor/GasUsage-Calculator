﻿Console.WriteLine("~Use commas instead of dots~");
Console.Write("Enter the price of a liter of gasoline: ");
double gasprice = double.Parse(Console.ReadLine());
Console.Write("Write how far in kilometers the route is: ");
double km = double.Parse(Console.ReadLine());
Console.Write("How much kilometers per liter of gas can your car do: ");
double usagekm = double.Parse(Console.ReadLine());
double gaskm = gasprice / usagekm;
double result = km * gaskm;
Console.Write("You will spend on gas: $" + result);