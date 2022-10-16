using DotNetCoach.CSTricks.Data.Banking;

var from = Bank.CreateAccount(100);
var to = Bank.CreateAccount(100);

try
{
    Bank.TransferFunds(from, 200, to);
}
catch (InsufficientFundsException e) when (e.Account.IsVIP)
{
    // Handle VIP account
}
catch (InsufficientFundsException)
{
    // Handle mere mortals' accounts
    throw;
}