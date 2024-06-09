namespace Packt.Shared;

public class BankAccount
{
    public string? AccountName;  // could be null, instance member - different value for each instance
    public decimal Balance;  // defaults to zero, instance member - different value for each instance

    // static member to store single interest rate value for all BankAccount objects
    public static decimal InterestRate;  // defaults to zero, shared member, one value shared across all instances
}