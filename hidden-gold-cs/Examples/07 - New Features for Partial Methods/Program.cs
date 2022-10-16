using DotNetCoach.CSTricks.H;

Customer customer = new Customer
{
    Name = "Bruce Campbell"
};
customer.Name = "Saul Goodman";
Console.WriteLine($"The customer name is: {customer.Name}");
