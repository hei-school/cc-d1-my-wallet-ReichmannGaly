class Wallet {
    constructor() {
        this.balance = 0;
        this.transactions = [];
    }

    getBalance() {
        return +this.balance;
    }

    deposit(amount) {
        amount = +amount;
        if (amount > 0) {
            this.balance += amount;
            this.transactions.push(`Deposit: +${amount}`);
            console.log("\nSuccessful deposit.");
        } else{
            console.log("Please enter a valid amount!")
        }
    }

    withdraw(amount) {
        amount = +amount;
        if (this.balance >= amount){
            this.balance -= amount;
            this.transactions.push(`Withdrawal: -${amount}`)
            console.log("\nSuccessful withdrawal.");
        } else {
            console.log("\nInsufficient funds!")
        }
    }

    getTransactions(){
        return this.transactions
    }
}

module.exports = Wallet;