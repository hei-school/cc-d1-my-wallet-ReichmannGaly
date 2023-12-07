const Wallet = require('./wallet');
const prompt = require("prompt-sync")(); 

class WalletApp {
    static main() {
        const wallet = new Wallet();
        let isLoggedIn = true;

        while (isLoggedIn) {
            console.log("\n1. Deposit\n2. Withdraw\n3. View Balance\n4. View Transactions\n5. Logout");

            const choice = prompt("\nPlease choose an option: ");

            switch (parseInt(choice)) {
                case 1:
                    const depositAmount = prompt("Enter deposit amount: ");
                    wallet.deposit(depositAmount);
                    break;
                case 2:
                    const withdrawalAmount = prompt("Enter withdrawal amount: ");
                    wallet.withdraw(withdrawalAmount);
                    break;
                case 3: 
                    console.log("\nBalance: " + wallet.getBalance());
                    break;
                case 4:
                    console.log("\nTransactions: " + wallet.getTransactions());
                    break;
                case 5 : 
                    console.log("\nLogged out successfully. ");
                    isLoggedIn = false;
                    break;
                default:
                    console.log("\nInvalid choice!");
            }
        }
    }
}

WalletApp.main();