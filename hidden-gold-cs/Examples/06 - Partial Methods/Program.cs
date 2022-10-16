using System;
using DotNetCoach.CSTricks.H;

Customer customer = new()
{
    Name = "Bruce Campbell"
};
customer.Name = "Saul Goodman";
Console.WriteLine($"The customer name is: {customer.Name}");