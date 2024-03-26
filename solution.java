class Account {
    private double balance;

    public Account(double balance) {
        this.balance = balance;
    }

    public double getBalance() {
        return balance;
    }

    public void deposit(double amount) {
        balance += amount;
    }

    public void withdraw(double amount) {
        if (balance >= amount) {
            balance -= amount;
        } else {
            System.out.println("Insufficient balance");
        }
    }

    public void transfer(Account to, double amount) {
        if (balance >= amount) {
            withdraw(amount);
            to.deposit(amount);
        } else {
            System.out.println("Insufficient balance");
        }
    }
}