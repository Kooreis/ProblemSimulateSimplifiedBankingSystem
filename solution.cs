public void Deposit(decimal amount)
{
    Balance += amount;
}

public void Withdraw(decimal amount)
{
    if (Balance >= amount)
    {
        Balance -= amount;
    }
    else
    {
        Console.WriteLine("Insufficient balance");
    }
}