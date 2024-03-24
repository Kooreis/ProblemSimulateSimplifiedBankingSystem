```C#
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

    public void Transfer(Account toAccount, decimal amount)
    {
        if (Balance >= amount)
        {
            Withdraw(amount);
            toAccount.Deposit(amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Account account1 = new Account("001", 500);
        Account account2 = new Account("002", 300);

        account1.Deposit(200);
        Console.WriteLine("Account 1 balance: " + account1.Balance);

        account1.Withdraw(100);
        Console.WriteLine("Account 1 balance: " + account1.Balance);

        account1.Transfer(account2, 200);
        Console.WriteLine("Account 1 balance: " + account1.Balance);
        Console.WriteLine("Account 2 balance: " + account2.Balance);
    }
}
```