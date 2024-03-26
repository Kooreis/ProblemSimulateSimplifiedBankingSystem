def deposit(self, amount):
        self.balance += amount
        print(f"Deposited {amount} to account {self.id}. New balance: {self.balance}")