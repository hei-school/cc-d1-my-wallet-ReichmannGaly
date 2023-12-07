from wallet import Wallet

class WalletApp:
    @staticmethod
    def main():
        wallet = Wallet()
        is_logged_in = True

        while is_logged_in:
            print("\n1. Deposit\n2. Withdraw\n3. View Balance\n4. View Transactions\n5. Logout")
            choice = int(input("\nPlease choose an option: "))

            if choice == 1:
                deposit_amount = float(input("\n Enter deposit amount: "))
                wallet.deposit(deposit_amount)
            elif choice == 2:
                withdrawal_amount = float(input("\n Enter withdrawal amount: "))
                wallet.withdraw(withdrawal_amount)
            elif choice == 3:
                print("\nBalance:", wallet.get_balance())
            elif choice == 4:
                print("\nF#Transactions:", wallet.get_transactions())
            elif choice == 5:
                print("\nLogged out successfully.")
                is_logged_in = False
            else:
                print("Invalid choice!")

if __name__ == "__main__":
    WalletApp.main()