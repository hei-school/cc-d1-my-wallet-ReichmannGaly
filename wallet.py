class Wallet:
    def __init__(self):
        self.balance = 0
        self.transactions = []
    
    def get_balance(self):
        return self.balance
    
    def deposit(self, amount):
        if amount > 0:
            self.balance += amount
            self.transactions.append(f"Deposit: +{amount}")
            print("\nSuccessful deposit.")
        else: 
            print("\nPlease enter a valid amount!")
    
    def withdraw(self, amount):
        if self.balance >= amount:
            self.balance -= amount
            self.transactions.append(f"Withdraw: +{amount}")
            print("\nSuccessful withdrawal.")
        else:
            print("\nInsufficient funds!")

    def get_transactions(self):
        return self.transactions            