```python
class Account:
    def __init__(self, id, balance):
        self.id = id
        self.balance = balance

    def deposit(self, amount):
        self.balance += amount
        print(f"Deposited {amount} to account {self.id}. New balance: {self.balance}")

    def withdraw(self, amount):
        if amount > self.balance:
            print("Insufficient balance!")
        else:
            self.balance -= amount
            print(f"Withdrew {amount} from account {self.id}. New balance: {self.balance}")

    def transfer(self, target_account, amount):
        if amount > self.balance:
            print("Insufficient balance!")
        else:
            self.balance -= amount
            target_account.balance += amount
            print(f"Transferred {amount} from account {self.id} to account {target_account.id}. New balance: {self.balance}")


def main():
    account1 = Account(1, 1000)
    account2 = Account(2, 2000)

    account1.deposit(500)
    account1.withdraw(200)
    account1.transfer(account2, 300)

    account2.deposit(1000)
    account2.withdraw(500)
    account2.transfer(account1, 700)


if __name__ == "__main__":
    main()
```