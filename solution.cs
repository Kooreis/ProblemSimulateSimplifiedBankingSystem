using System;

public class Account
{
    public string Id { get; private set; }
    public decimal Balance { get; private set; }

    public Account(string id, decimal initialBalance)
    {
        Id = id;
        Balance = initialBalance;
    }
}